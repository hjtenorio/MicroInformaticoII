import bodyParser from 'body-parser';
import cors from 'cors';
import express from 'express';
import nanoid from 'nanoid';

const app = express();
app.use(cors());
app.use(bodyParser.json());

app.get('/', (req, res) => {
  res.send('cvp-group-app backend mock');
});

app.post('/api/v1/Identity/Authenticate', (req, res) => {
  res.json({
    authToken: 'qwerty',
    response: {
      data: {
        username: '10004058',
        nombre: 'Jennifer',
        apellido: 'Smith',
        email: 'jsmith@valtx.pe',
      },
    },
    menu: {
      menu: [
        {
          id: 'microinformatico',
          title: 'Microinformatico',
          children: [
            {
              key: 1,
              url: '/home',
              title: 'Inicio',
            },
            {
              key: 2,
              url: '/assets/tickets/add',
              title: 'Nuevo Ticket',
            },
            {
              key: 3,
              url: '/assets/tickets',
              title: 'Mis Ticket',
            },
            {
              key: 4,
              url: '/assets/stolen-alert',
              title: 'Reporte de Robo',
            },
            {
              key: 5,
              url: '/assets/asset-return',
              title: 'Devolucion de Equipo',
            },
          ],
        },
      ],
    },
  });
});

app.get('/api/v1/tracking/tickets-list-employee', (req, res) => {
  const { query } = req;
  console.log(query);

  const list = [
    {
      id: 64515,
      ticketNumber: '080062161',
      serviceTypeId: 2,
      serviceType: 'Incidencia',
      title: 'PUESTO DE TRABAJO::ESTACION::PUNTO DE RED SIN SEÑAL: HN061764',
      createTime: '2020-03-17T20:12:05',
      statusId: 1,
      status: 'Nuevo',
    },
    {
      id: 64513,
      ticketNumber: '080062159',
      serviceTypeId: 2,
      serviceType: 'Incidencia',
      title: 'APLICATIVOS WEB::EASYLOG::PROBLEMAS DE ACCESO: HN061764',
      createTime: '2020-03-17T18:38:43',
      statusId: 1,
      status: 'Nuevo',
    },
    {
      id: 64512,
      ticketNumber: '080062158',
      serviceTypeId: 2,
      serviceType: 'Incidencia',
      title: 'PUESTO DE TRABAJO::COMUNICACIONES::LENTITUD EN EL ENLACE: HN061765',
      createTime: '2020-03-17T18:36:57',
      statusId: 1,
      status: 'Nuevo',
    },
    { id: 64501, ticketNumber: '080062147', serviceTypeId: 2, serviceType: 'Incidencia', title: 'Robo del equipo HN061766', createTime: '2020-03-13T23:28:51', statusId: 1, status: 'Nuevo' },
    { id: 64500, ticketNumber: '080062146', serviceTypeId: 2, serviceType: 'Incidencia', title: 'Robo del equipo HN061763', createTime: '2020-03-13T23:26:29', statusId: 1, status: 'Nuevo' },
    { id: 64516, ticketNumber: '080064516', serviceTypeId: 2, serviceType: 'Incidencia', title: 'Robo del equipo HN061766', createTime: '2020-03-13T23:28:51', statusId: 1, status: 'Nuevo' },
    { id: 64517, ticketNumber: '080064517', serviceTypeId: 2, serviceType: 'Incidencia', title: 'Robo del equipo HN061763', createTime: '2020-03-13T23:26:29', statusId: 1, status: 'Nuevo' },
    { id: 64333, ticketNumber: '080064333', serviceTypeId: 7, serviceType: 'Requerimiento', title: 'Requerimiento', createTime: '2020-03-13T23:28:51', statusId: 1, status: 'Nuevo' },
    { id: 64999, ticketNumber: '080064999', serviceTypeId: 7, serviceType: 'Requerimiento', title: 'Requerimiento', createTime: '2020-03-13T23:26:29', statusId: 1, status: 'Nuevo' },
  ];

  const filterByServiceTypeId = (el) => (!query.serviceTypeId ? true : el.serviceTypeId.toString() === query.serviceTypeId);
  const filterByTicketNumber = (el) => (query.nroTicketTitle ? el.ticketNumber.toLowerCase().indexOf(query.nroTicketTitle) !== -1 : true);
  const dataQuery = list.filter(filterByServiceTypeId).filter(filterByTicketNumber);
  const count = dataQuery.length;
  const { pageIndex, pageSize } = query;
  const dataPaginated = dataQuery.splice(pageIndex * pageSize, pageSize);

  const response = {
    pageIndex,
    pageSize,
    data: dataPaginated,
    count,
  };

  res.json(response);
});

// /AssetsIT/api/v1/tracking/tickets-list-employee?serviceTypeId=2&nroDni=10004158&pageIndex=0&pageSize=5

const server = app.listen(5100, () => {
  // eslint-disable-next-line no-console
  console.log(`[micro2]: Backend listening on port ${server.address().port}`);
});
