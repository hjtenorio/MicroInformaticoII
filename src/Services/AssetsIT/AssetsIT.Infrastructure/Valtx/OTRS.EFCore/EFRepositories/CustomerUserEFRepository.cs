using AssetsIT.Domain.AggregatesModel.CustomerUserAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFRepositories
{
    public class CustomerUserEFRepository : ICustomerUserRepository
    {
        private OTRSContext _OTRSContext;

        public CustomerUserEFRepository(OTRSContext OTRSContext) {
            _OTRSContext = OTRSContext;
        }

        public async Task<CustomerUserData> GetCustomerUserByDni(string nroDni) {
            var result = (from cu in _OTRSContext.CustomerUser
                          where cu.Dni == nroDni && cu.ValidId == 1
                          select new CustomerUserData {
                              Id = cu.Id,
                              Email = cu.Email,
                              CustomerId = cu.CustomerId,
                              Dni = cu.Dni,
                              FirstName = cu.FirstName,
                              LastName = cu.LastName,
                              Street = cu.Street,
                              Phone = cu.Phone
                          });

            return await result.FirstOrDefaultAsync();
        }

        public async Task<CustomerUserData> GetCustomerUserByCip(string nroCip) {
            var result = (from cu in _OTRSContext.CustomerUser
                          where cu.CustomerId == nroCip && cu.ValidId == 1
                          select new CustomerUserData {
                              Id = cu.Id,
                              Email = cu.Email,
                              CustomerId = cu.CustomerId,
                              Dni = cu.Dni,
                              FirstName = cu.FirstName,
                              LastName = cu.LastName,
                              Street = cu.Street,
                              Phone = cu.Phone
                          });

            return await result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CustomerUserData>> GetListCustomerUserTermination(CustomerCessationSearch search) {
            var response = await _OTRSContext.SpListUserCese.FromSqlInterpolated(
                    $"CALL sp_list_user_cese({search.ChiefCustomerId},{search.FullName},{search.StartDate},{search.EndtDate});"
                ).ToListAsync();

            var result = (from cu in response
                          select new CustomerUserData {
                              Id = cu.Id,
                              Email = cu.Email,
                              CustomerId = cu.CustomerId,
                              Dni = cu.Dni,
                              FirstName = cu.FirstName,
                              LastName = cu.LastName,
                              RenewalDate = cu.RenewalDate,
                              RenewalStatus = cu.RenewalDate == null ? false : true,
                              TerminationDate = cu.TerminationDate
                          }).ToList();

            return result;
        }

        public async Task<IEnumerable<CustomerUserData>> GetListCustomerUserTerminationNotRenew(string initialNameBusinness) {
            var result = (from cu in _OTRSContext.CustomerUser
                          where cu.DateCessation >= DateTime.Now.AddDays(-1) &&
                                cu.DateCessation < DateTime.Now &&
                                cu.DateEndcontrat == null &&
                                cu.ValidId == 1 && cu.FlagDevolEquipo == 0 &&
                                cu.Sigla == initialNameBusinness
                          orderby cu.DateCessation ascending
                          select new CustomerUserData {
                              Id = cu.Id,
                              Email = cu.Email,
                              CustomerId = cu.CustomerId,
                              Dni = cu.Dni,
                              FirstName = cu.FirstName,
                              LastName = cu.LastName,
                              RenewalDate = cu.DateEndcontrat,
                              TerminationDate = cu.DateCessation
                          });

            return await result.ToListAsync();
        }

        public async Task<IEnumerable<CustomerUserData>> GetListCustomerUserChief(string initialNameBusinness) {
            var result = (from cu in _OTRSContext.CustomerUser
                          where cu.Sigla == initialNameBusinness && cu.ValidId == 1
                          select new CustomerUserData {
                              Id = cu.Id,
                              Email = cu.Email,
                              CustomerId = cu.CustomerId,
                              Dni = cu.Dni,
                              FirstName = cu.FirstName,
                              LastName = cu.LastName,
                              Charge = cu.Cargo
                          });

            result = result.Where(cu => Regex.IsMatch(cu.Charge, LikeToRegular("%sub%")));

            return await result.ToListAsync();
        }

        public bool UpdateBulkListCustomersCessation(List<CustomerCessationUpdate> customer) {
            using (var transac = _OTRSContext.Database.BeginTransaction()) {
                bool result;
                try {
                    foreach (var item in customer) {
                        var obj = _OTRSContext.CustomerUser.Find(item.IdUser);
                        obj.DateEndcontrat = item.DateEndcontrat;
                        _OTRSContext.SaveChanges();
                    }
                    transac.Commit();
                    result = true;
                } catch (Exception ex) {
                    var message = ex.Message;
                    transac.Rollback();
                    result = false;
                }
                return result;
            }
        }

        public bool UpdateCustomerUserAssetReturn(int userId) {
            bool result;
            try {
                var obj = _OTRSContext.CustomerUser.Find(userId);
                obj.FlagDevolEquipo = 1;
                _OTRSContext.SaveChanges();

                result = true;
            } catch (Exception ex) {
                var message = ex.Message;
                result = false;
            }

            return result;
        }

        private static String LikeToRegular(String value) {
            return "^" + Regex.Escape(value).Replace("_", ".").Replace("%", ".*") + "$";
        }
    }
}