using AssetsIt.BackgroundTasks.Interfaces;
using AssetsIT.BackgroundTasks.Services;
using AssetsIT.Domain.AggregatesModel.AssetsAggregate;
using AssetsIT.Domain.AggregatesModel.CustomerUserAggregate;
using AssetsIT.Domain.AggregatesModel.TicketAggregate;
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
    public class CreateTerminatedUserStaffAssetsReturnTicketsTask
        : IBackgroundTask
    {
        private readonly ISmtpService _smtpService;
        public IConfiguration _configuration;

        public CreateTerminatedUserStaffAssetsReturnTicketsTask(
            ISmtpService smtpService, IConfiguration configuration) {
            _smtpService = smtpService;
            _configuration = configuration;
        }

        public async Task ExecuteAsync() {
            Log.Information("Iniciando ejecucion de tarea de integracion => CreateTerminatedUserStaffAssetsReturnTicketsTask");

            string url = _configuration.GetValue<string>("UrlServers:AssetsIT");

            Log.Information("Consulta de Usuarios sin renovación de contrato mediante HttpClient al API");

            using (HttpClient client = new HttpClient()) {
                StringBuilder result = new StringBuilder();

                List<TicketCreateResponse> ticketCreateList = new List<TicketCreateResponse>();

                List<CustomerUserData> employeeList = new List<CustomerUserData>();
                var responseEmployee = await client.GetAsync(url + "/api/v1/customeruser/norenew?initialsNameBusiness=TGS");
                string apiResponseEmployee = await responseEmployee.Content.ReadAsStringAsync();
                employeeList = JsonConvert.DeserializeObject<List<CustomerUserData>>(apiResponseEmployee);

                if (employeeList.Count() > 0) {
                    foreach (CustomerUserData user in employeeList) {
                        var responseAssets = await client.GetAsync(url + "/api/v1/asset?ownerId=" + user.Dni);

                        string apiResponseAsset = await responseAssets.Content.ReadAsStringAsync();
                        List<Asset> assetList = JsonConvert.DeserializeObject<List<Asset>>(apiResponseAsset);

                        var valuesPostNoRenew = new Dictionary<string, string>
                        {
                            { "customerId", user.CustomerId },
                            { "assetId", assetList.FirstOrDefault().Id }
                        };
                        var contentValuesPostRenew = new FormUrlEncodedContent(valuesPostNoRenew);

                        var ticketCreateReponse = await client.PostAsync(url + "/api/v1/ticket/norenew", contentValuesPostRenew);
                        string apiResponseTicketCreate = await ticketCreateReponse.Content.ReadAsStringAsync();
                        TicketCreateResponse ticketCreate = JsonConvert.DeserializeObject<TicketCreateResponse>(apiResponseTicketCreate);

                        if (ticketCreate.TicketID != null) {
                            ticketCreateList.Add(new TicketCreateResponse { ArticleID = ticketCreate.ArticleID, TicketID = ticketCreate.TicketID, TicketNumber = ticketCreate.TicketNumber });
                            if (assetList.Count() > 1) {
                                var itemAssetList = from p in assetList
                                                    where p.Id != assetList.FirstOrDefault().Id
                                                    select p;
                                foreach (Asset itemAsset in itemAssetList) {
                                    var valuesPutNoRenew = new Dictionary<string, string>
                                    {
                                        { "ticketId", ticketCreate.TicketID },
                                        { "customerId", user.CustomerId },
                                        { "street", user.Street },
                                        { "assetId", itemAsset.Id }
                                    };
                                    var contentValuesPutNoRenew = new FormUrlEncodedContent(valuesPutNoRenew);

                                    var ticketUpdateReponse = await client.PutAsync(url + "/api/v1/ticket/norenew", contentValuesPutNoRenew);
                                    string apiResponseTicketUpdate = await ticketUpdateReponse.Content.ReadAsStringAsync();
                                    TicketUpdateResponse ticketUpdate = JsonConvert.DeserializeObject<TicketUpdateResponse>(apiResponseTicketUpdate);
                                    if (ticketUpdate != null) {
                                        ticketCreateList.Add(new TicketCreateResponse { ArticleID = ticketUpdate.ArticleID, TicketID = ticketUpdate.TicketID, TicketNumber = ticketUpdate.TicketNumber });
                                    }
                                }
                            }
                        }
                    }

                    if (ticketCreateList != null) {
                        result.AppendFormat(
                            @"<html><body>Lista de tickets creados por cese para el recojo de equipos:
                            <table class='table table-bordered'><tr><th scope='col'>Ticket ID</th><th scope='col'>Nro. Ticket</th><th scope='col'>Artículo ID</th></tr>"
                        );
                        foreach (TicketCreateResponse item in ticketCreateList) {
                            result.AppendFormat(
                                @"<tr><td> {0}</td>
                                <tr><td> {1}</td>
                                <tr><td> {2}</td></tr></body></html>",
                            item.TicketID, item.TicketNumber, item.ArticleID);
                        }
                        result.AppendFormat(@"</tbody></table>");

                        var sendEmailAdmin = await _smtpService.SendEmailAdministratorSystem(result, "Microinformático - Estado de envío de correos a jefes por cese");
                        Log.Information(sendEmailAdmin ? "Se envío el correo al administrador del correo." : "No se logró enviar el correo a administradores.");
                        Log.Information("Secuencia de integracion finalizada.");
                    } else {
                        result.AppendFormat("No se generó ningún ticket.");

                        var sendEmailAdmin = await _smtpService.SendEmailAdministratorSystem(result, "Microinformático - Estado de generación de ticket por cese");

                        Log.Information(sendEmailAdmin ? "Se envío el correo al administrador del correo." : "No se logró enviar el correo a administradores.");

                        Log.Information("Secuencia de integración finalizada.");
                    }
                } else {
                    Log.Information("Secuencia de integración finalizada. No hay colaboradores por cesados");
                }

            }
        }
    }
}