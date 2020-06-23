using AssetsIt.BackgroundTasks.Interfaces;
using AssetsIT.BackgroundTasks.Models;
using AssetsIT.BackgroundTasks.Services;
using AssetsIT.Domain.AggregatesModel.CustomerUserAggregate;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AssetsIT.BackgroundTasks.Tasks
{
    public class SendUserStaffTerminationNotificationTask : IBackgroundTask
    {
        private readonly ISmtpService _smtpService;
        public IConfiguration _configuration;

        public SendUserStaffTerminationNotificationTask(ISmtpService smtpService,
            IConfiguration configuration) {
            _smtpService = smtpService;
            _configuration = configuration;
        }
        public async Task ExecuteAsync() {
            Log.Information("Iniciando ejecución de tarea de integración => SendUserStaffTerminationNotificationTask");

            string url = _configuration.GetValue<string>("UrlServers:AssetsIT");

            Log.Information("Consulta de Jefes mediante HttpClient al API");

            var countNroEmployees = 0;

            StringBuilder result = new StringBuilder();
            result.AppendFormat(@"No se logró enviar ningún correo.");

            List<bool> listSendEmail = new List<bool>();

            using (HttpClient client = new HttpClient()) {
                List<CustomerUserData> chiefList = new List<CustomerUserData>();

                var responseChief = await client.GetAsync(url + "/api/v1/customeruser/chief-list?initialsNameBusiness=TGS");

                string apiResponseChief = await responseChief.Content.ReadAsStringAsync();
                chiefList = JsonConvert.DeserializeObject<List<CustomerUserData>>(apiResponseChief);

                foreach (CustomerUserData item in chiefList) {
                    var responseEmployee = await client.GetAsync(url + "/api/v1/customeruser/termination?nroDni=" + item.Dni);

                    string apiResponseEmployee = await responseEmployee.Content.ReadAsStringAsync();
                    var employeeList = JsonConvert.DeserializeObject<PaginatedItems<CustomerUserData>>(apiResponseEmployee);

                    if (employeeList.Count > 0) {
                        countNroEmployees = countNroEmployees + 1;
                        var sendEmail = await _smtpService.SendUserStaffTerminationNotificationEmail(item, employeeList.Count);
                        listSendEmail.Add(sendEmail);
                    }
                }

                var countSendEmail = (from item in listSendEmail
                                      where item == true
                                      select item).Count();

                result.AppendFormat(countNroEmployees == countSendEmail ?
                       "Se enviaron la siguiente cantidad de correos: " + countSendEmail + " de " + countNroEmployees + " correos." :
                       "No se logró enviar todos los correos: " + countSendEmail + " de " + countNroEmployees + " correos.");

                var sendEmailAdmin = await _smtpService.SendEmailAdministratorSystem(result, "Microinformático - Estado de envío de correos a jefes por cese");

                Log.Information(sendEmailAdmin ? "Se envío el correo al administrador del correo." : "No se logró enviar el correo a administradores.");

                Log.Information("Secuencia de integracion finalizada.");
            }
        }
    }
}