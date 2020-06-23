using AssetsIT.Domain.AggregatesModel.TicketAggregate;
using AssetsIT.Infrastructure.Valtx.OTRS.OTRSModels.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.OTRSClient
{
    public class OTRSClientRest
    {
        public OTRSClientRest()
        {
        }
        public TicketCreateResponse GenerateTicketCreateRequest(TicketCredencials ticketCredencials, TicketBodyCreateRequest ticket, List<AttachmentRequest> attachment)
        {
            string TARGETURL = ticketCredencials.WebBaseUrl;
            DateTime now = DateTime.Now;

            TicketBodyCreateRequest ticketRequest = new TicketBodyCreateRequest();
            ticketRequest.Year = now.ToString("yyyy");
            ticketRequest.Month = now.ToString("MM");
            ticketRequest.Day = now.ToString("dd");
            ticketRequest.Hour = now.ToString("HH");
            ticketRequest.Minute = now.ToString("mm");
            ticketRequest.UserLogin = ticketCredencials.UserLogin;
            ticketRequest.CustomerUserLogin = ticketCredencials.CustomerUserLogin;
            ticketRequest.Password = ticketCredencials.Password;
            ticketRequest.Ticket = ticket.Ticket;
            ticketRequest.Article = ticket.Article;
            if (attachment.Count() > 0)
            {
                ticketRequest.Attachment = attachment;
            }
            var response = JsonCreateTicketOtrs(TARGETURL, ticketRequest);

            return response;
        }

        public TicketUpdateResponse GenerateTicketUpdateRequest(long ticketId, TicketCredencials ticketCredencials, TicketBodyUpdateRequest ticket, List<AttachmentRequest> attachment)
        {
            string TARGETURL = ticketCredencials.WebBaseUrl + "/" + ticketId;

            TicketBodyUpdateRequest ticketRequest = new TicketBodyUpdateRequest();
            ticketRequest.UserLogin = ticketCredencials.UserLogin;
            ticketRequest.CustomerUserLogin = ticketCredencials.CustomerUserLogin;
            ticketRequest.Password = ticketCredencials.Password;
            ticketRequest.Article = ticket.Article;
            if (attachment.Count() > 0)
            {
                ticketRequest.Attachment = attachment;
            }
            var response = JsonUpdateTicketOtrs(TARGETURL, ticketRequest);

            return response;
        }

        private TicketCreateResponse JsonCreateTicketOtrs(string TARGETURL, TicketBodyCreateRequest ticketRequest)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(TARGETURL);
            request.KeepAlive = false;
            request.ProtocolVersion = HttpVersion.Version10;
            request.Method = "POST";
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "application/json";

            string json = JsonConvert.SerializeObject(ticketRequest);
            byte[] postBytes = Encoding.UTF8.GetBytes(json);
            request.ContentLength = postBytes.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                var respuesta = rdr.ReadToEnd();
                var responseApi = JsonConvert.DeserializeObject<TicketCreateResponse>(respuesta);
                return responseApi;
            }
        }

        private TicketUpdateResponse JsonUpdateTicketOtrs(string TARGETURL, TicketBodyUpdateRequest ticketRequest)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(TARGETURL);
            request.KeepAlive = false;
            request.ProtocolVersion = HttpVersion.Version10;
            request.Method = "PATCH";
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "application/json";

            string json = JsonConvert.SerializeObject(ticketRequest);
            byte[] postBytes = Encoding.UTF8.GetBytes(json);
            request.ContentLength = postBytes.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                var respuesta = rdr.ReadToEnd();
                var responseApi = JsonConvert.DeserializeObject<TicketUpdateResponse>(respuesta);
                return responseApi;
            }
        }
    }
}