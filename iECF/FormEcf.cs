using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using RestSharp;

namespace iECF
{
    public partial class FormEcf : Form
    {

        public FormEcf(DataGridView dataGridView1)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoCf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEncf_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xml = "";
            var client = new RestClient("https://ecf.dgii.gov.do/TesteCF/autenticacion/api/Autenticacion/Semilla");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK && response.ErrorMessage == null && response.Content.Length > 1)
            {
                xml = response.Content;
                FirmarAsync(xml, txtTipoCf, txtEncf);
                


            }

            void FirmarAsync(string xml, TextBox txttipocf, TextBox txtencf)
            {

                Comp_ElectronicosEntities1 db = new Comp_ElectronicosEntities1();
                string empty = string.Empty;
                List<XmlDocument> xmlDocuments = new List<XmlDocument>();
                try
                {
                    string Certificate = @"C:\ECF\20211129-1331448-EQHLPXY6H.p12";
                    string xmldata = "E:\\xmlFirmado.xml";

                    XmlDocument xmlDocument = SignServices.Current.FirmarXml(xmldata, Certificate, "C3r@1c0n", false, xml);
                    string[] strArrays = xmldata.Split(new char[] { '\\' });
                    string str = strArrays[(int)strArrays.Length - 1].Split(new char[] { '.' })[0];
                    DateTime now = DateTime.Now;
                    string str1 = string.Concat(str, string.Concat("_", now.ToString("HHMMss"), ".xml"));
                    string str2 = string.Concat(strArrays[0], string.Concat("\\", str1));
                    var client = new RestClient("https://ecf.dgii.gov.do/TesteCF/Autenticacion/api/Autenticacion/ValidarSemilla");
                    client.Timeout = -1;
                    var request = new RestRequest(Method.POST);
                    byte[] bytes = Encoding.Default.GetBytes(xmlDocument.OuterXml);
                    request.AddFile("xml", bytes, str1);
                    IRestResponse response = client.Execute(request);
                    RestSharp.Serialization.Json.JsonDeserializer t = new RestSharp.Serialization.Json.JsonDeserializer();
                    var rest = t.Deserialize<DgiiToken>(response);
                    db.DgiiTokens.Add(rest);
                    db.SaveChanges();
                    //Console.WriteLine("Token :");
                    //Console.WriteLine(rest.token);
                    client = new RestClient("https://ecf.dgii.gov.do/TesteCF/Recepcion/api/FacturasElectronicas");
                    request = new RestRequest(Method.POST);
                    request.AddHeader("accept", "application/json");
                    string auth = "Bearer " + rest.token;
                    request.AddHeader("Authorization", auth);
                    request.AddHeader("Content-Type", "multipart/form-data");
                    bytes = Encoding.Default.GetBytes(xmlDocument.OuterXml);
                    string nombre = "";
                    string encf1 = txtencf.Text;
                    
                    
                    Comp_ElectronicosEntities1 comp = new Comp_ElectronicosEntities1();

                    ECF eCF = new ECF();
                    ECFEncabezado encabezado = new ECFEncabezado();
                    string fechaVencimiento; 
                    int? indicadorMontoGravado;
                    string tipoIngresos;
                    string rNCEmisor;
                    string razonSocialEmisor;
                    string direccionEmisor;
                    string fechaEmision;
                    string rNCComprador;
                    string razonSocialComprador;
                    decimal? montoGravadoTotal;
                    decimal? montoGravadoI1;
                    decimal? MontoExento;
                    short? iTBIS1;
                    decimal? TotalITBIS1;
                    decimal montoTotal;
                    short? numeroLinea;
                    int? indicadorFacturacion;
                    string nombreItem;
                    decimal? cantidadItem;
                    decimal? montoItem;
                    XmlSerializer serializer;
                    string CodigoSeguridad;
                    string FechaFirma;
                    string RncEmisor;
                    string RncComprador;
                    string ENCF;
                    string FechaEmision;
                    string MontoTotal;
                    string Qr;
                    int? retencion;
                    int idDoc;
                    

                    IRestResponse result;
                    RecepcionResult test;




                    string tipoCf = txttipocf.Text;

                    fechaVencimiento = (from o in comp.EcfEncabezadoes
                                        where o.EcfEncabezadoIdDoc.ENCF == encf1
                                        select o.EcfEncabezadoIdDoc.FechaVencimientoSecuencia).FirstOrDefault();
                    idDoc = (from o in comp.EcfEncabezadoes
                             where o.EcfEncabezadoIdDoc.ENCF == encf1
                             select o.EcfEncabezadoIdDoc.Id).FirstOrDefault();

                    indicadorMontoGravado = (from o in comp.EcfEncabezadoes
                                             where o.EcfEncabezadoIdDoc.ENCF == encf1
                                             select o.EcfEncabezadoIdDoc.IndicadorMontoGravado).FirstOrDefault();

                    tipoIngresos = (from o in comp.EcfEncabezadoes
                                    where o.EcfEncabezadoIdDoc.ENCF == encf1
                                    select o.EcfEncabezadoIdDoc.TipoIngresos).FirstOrDefault();

                    rNCEmisor = (from o in comp.EcfEncabezadoes
                                 where o.EcfEncabezadoIdDoc.ENCF == encf1
                                 select o.EcfEncabezadoEmisor.RNCEmisor).FirstOrDefault();

                    razonSocialEmisor = (from o in comp.EcfEncabezadoes
                                         where o.EcfEncabezadoIdDoc.ENCF == encf1
                                         select o.EcfEncabezadoEmisor.RazonSocialEmisor).FirstOrDefault();
                    direccionEmisor = (from o in comp.EcfEncabezadoes
                                       where o.EcfEncabezadoIdDoc.ENCF == encf1
                                       select o.EcfEncabezadoEmisor.DireccionEmisor).FirstOrDefault();
                    fechaEmision = (from o in comp.EcfEncabezadoes
                                    where o.EcfEncabezadoIdDoc.ENCF == encf1
                                    select o.EcfEncabezadoEmisor.FechaEmision).FirstOrDefault();
                    rNCComprador = (from o in comp.EcfEncabezadoes
                                    where o.EcfEncabezadoIdDoc.ENCF == encf1
                                    select o.EcfEncabezadoComprador.RNCComprador).FirstOrDefault();
                    razonSocialComprador = (from o in comp.EcfEncabezadoes
                                            where o.EcfEncabezadoIdDoc.ENCF == encf1
                                            select o.EcfEncabezadoComprador.RazonSocialComprador).FirstOrDefault();
                    montoGravadoTotal = (from o in comp.EcfEncabezadoes
                                         where o.EcfEncabezadoIdDoc.ENCF == encf1
                                         select o.EcfEncabezadoTotale.MontoGravadoTotal).FirstOrDefault();
                    montoGravadoI1 = (from o in comp.EcfEncabezadoes
                                      where o.EcfEncabezadoIdDoc.ENCF == encf1
                                      select o.EcfEncabezadoTotale.MontoGravadoI1).FirstOrDefault();
                    MontoExento = (from o in comp.EcfEncabezadoes
                                   where o.EcfEncabezadoIdDoc.ENCF == encf1
                                   select o.EcfEncabezadoTotale.MontoExento).FirstOrDefault();
                    iTBIS1 = (from o in comp.EcfEncabezadoes
                              where o.EcfEncabezadoIdDoc.ENCF == encf1
                              select o.EcfEncabezadoTotale.ITBIS1).FirstOrDefault();
                    TotalITBIS1 = (from o in comp.EcfEncabezadoes
                                   where o.EcfEncabezadoIdDoc.ENCF == encf1
                                   select o.EcfEncabezadoTotale.TotalITBIS1).FirstOrDefault();
                    montoTotal = (from o in comp.EcfEncabezadoes
                                  where o.EcfEncabezadoIdDoc.ENCF == encf1
                                  select o.EcfEncabezadoTotale.MontoTotal).FirstOrDefault();
                    numeroLinea = (from o in comp.EcfEncabezadoes
                                   where o.EcfEncabezadoIdDoc.ENCF == encf1
                                   select o.ECFDetallesItemsItem.NumeroLinea).FirstOrDefault();
                    indicadorFacturacion = (from o in comp.EcfEncabezadoes
                                            where o.EcfEncabezadoIdDoc.ENCF == encf1
                                            select o.ECFDetallesItemsItem.IndicadorFacturacion).FirstOrDefault();
                    nombreItem = (from o in comp.EcfEncabezadoes
                                  where o.EcfEncabezadoIdDoc.ENCF == encf1
                                  select o.ECFDetallesItemsItem.NombreItem).FirstOrDefault();
                    cantidadItem = (from o in comp.EcfEncabezadoes
                                    where o.EcfEncabezadoIdDoc.ENCF == encf1
                                    select o.ECFDetallesItemsItem.CantidadItem).FirstOrDefault();
                    montoItem = (from o in comp.EcfEncabezadoes
                                 where o.EcfEncabezadoIdDoc.ENCF == encf1
                                 select o.ECFDetallesItemsItem.MontoItem).FirstOrDefault();
                    retencion = (int?)(from o in comp.EcfEncabezadoes
                                       where o.EcfEncabezadoIdDoc.ENCF == encf1
                                       select o.ECFDetallesItemsItem.ECFDetallesItemsItemRetencion.MontoISRRetenido).FirstOrDefault();
                    switch (tipoCf)
                    {
                        case "31":
                            new ECF();
                            encabezado.IdDoc = new ECFEncabezadoIdDoc()
                            {
                                TipoeCF = tipoCf, //31
                                ENCF = encf1, //31
                                FechaVencimientoSecuencia = @"31-12-2022",
                                TipoIngresos = tipoIngresos,
                                TipoPago = TipoPagoType.Contado
                            };
                            encabezado.Emisor = new ECFEncabezadoEmisor()
                            {
                                RNCEmisor = rNCEmisor,
                                RazonSocialEmisor = razonSocialEmisor,
                                DireccionEmisor = direccionEmisor,
                                FechaEmision = fechaEmision
                            };
                            encabezado.Comprador = new ECFEncabezadoComprador()
                            {
                                RNCComprador = rNCComprador,
                                RazonSocialComprador = razonSocialComprador
                            };
                            encabezado.Totales = new ECFEncabezadoTotales()
                            {
                                MontoGravadoTotal = montoGravadoTotal,
                                MontoGravadoI1 = montoGravadoI1,
                                MontoExento = MontoExento,
                                ITBIS1 = (sbyte?)iTBIS1,
                                TotalITBIS1 = TotalITBIS1,
                                MontoTotal = montoTotal
                            };
                            eCF.Encabezado = encabezado;
                            eCF.DetallesItems.Add(new global::ECFDetallesItemsItem()
                            {
                                NumeroLinea = (short)numeroLinea,
                                IndicadorFacturacion = indicadorFacturacion,

                                NombreItem = nombreItem,
                                CantidadItem = (decimal)cantidadItem,
                                PrecioUnitarioItem = 8200,
                                MontoItem = (decimal)montoItem,

                            });
                            break;
                        case "32":

                            encabezado.IdDoc = new ECFEncabezadoIdDoc()
                            {
                                TipoeCF = tipoCf, //31
                                ENCF = encf1, //31
                                IndicadorMontoGravado = (IndicadorMontoGravadoType?)indicadorMontoGravado,
                                TipoIngresos = tipoIngresos,
                                TipoPago = TipoPagoType.Contado
                            };
                            encabezado.Emisor = new ECFEncabezadoEmisor()
                            {
                                RNCEmisor = rNCEmisor,
                                RazonSocialEmisor = razonSocialEmisor,
                                DireccionEmisor = direccionEmisor,
                                FechaEmision = fechaEmision
                            };
                            encabezado.Comprador = new ECFEncabezadoComprador()
                            {
                                RNCComprador = rNCComprador,
                                RazonSocialComprador = razonSocialComprador
                            };
                            encabezado.Totales = new ECFEncabezadoTotales()
                            {
                                MontoGravadoTotal = montoGravadoTotal,
                                MontoGravadoI1 = montoGravadoI1,
                                MontoExento = MontoExento,
                                ITBIS1 = (sbyte?)iTBIS1,
                                TotalITBIS1 = TotalITBIS1,
                                MontoTotal = montoTotal
                            };
                            eCF.Encabezado = encabezado;

                            eCF.DetallesItems.Add(new global::ECFDetallesItemsItem()
                            {
                                NumeroLinea = (short)numeroLinea,
                                IndicadorFacturacion = indicadorFacturacion,

                                NombreItem = nombreItem,
                                CantidadItem = (decimal)cantidadItem,
                                PrecioUnitarioItem = 8200,
                                MontoItem = (decimal)montoItem,

                            });
                            break;
                        case "44":
                            encabezado.IdDoc = new ECFEncabezadoIdDoc()
                            {
                                TipoeCF = tipoCf, //31
                                ENCF = encf1, //31
                                FechaVencimientoSecuencia = @"31-12-2022",
                                TipoIngresos = tipoIngresos,
                                TipoPago = TipoPagoType.Contado
                            };
                            encabezado.Emisor = new ECFEncabezadoEmisor()
                            {
                                RNCEmisor = rNCEmisor,
                                RazonSocialEmisor = razonSocialEmisor,
                                DireccionEmisor = direccionEmisor,
                                FechaEmision = fechaEmision
                            };
                            encabezado.Comprador = new ECFEncabezadoComprador()
                            {
                                RNCComprador = rNCComprador,
                                RazonSocialComprador = razonSocialComprador.ToString()
                            };
                            encabezado.Totales = new ECFEncabezadoTotales()
                            {
                                MontoExento = MontoExento,
                                MontoTotal = montoTotal
                            };

                            eCF.Encabezado = encabezado;
                            eCF.DetallesItems.Add(new global::ECFDetallesItemsItem()
                            {
                                NumeroLinea = (short)numeroLinea,
                                IndicadorFacturacion = indicadorFacturacion,
                                NombreItem = nombreItem,
                                CantidadItem = (decimal)cantidadItem,
                                PrecioUnitarioItem = 8200,
                                MontoItem = (decimal)montoItem,

                            });

                            break;
                        case "45":
                            encabezado.IdDoc = new ECFEncabezadoIdDoc()
                            {
                                TipoeCF = tipoCf, //31
                                ENCF = encf1, //31
                                              //FechaVencimientoSecuencia = @"31-12-2022",
                                IndicadorMontoGravado = (IndicadorMontoGravadoType?)indicadorMontoGravado,
                                TipoIngresos = tipoIngresos,
                                TipoPago = TipoPagoType.Contado
                            };
                            encabezado.Emisor = new ECFEncabezadoEmisor()
                            {
                                RNCEmisor = rNCEmisor,
                                RazonSocialEmisor = razonSocialEmisor,
                                DireccionEmisor = direccionEmisor,
                                FechaEmision = fechaEmision
                            };
                            encabezado.Comprador = new ECFEncabezadoComprador()
                            {
                                RNCComprador = rNCComprador,
                                RazonSocialComprador = razonSocialComprador.ToString()
                            };
                            encabezado.Totales = new ECFEncabezadoTotales()
                            {
                                MontoGravadoTotal = montoGravadoTotal,
                                MontoGravadoI1 = montoGravadoI1,
                                MontoExento = MontoExento,
                                ITBIS1 = (sbyte?)iTBIS1,
                                TotalITBIS1 = TotalITBIS1,
                                MontoTotal = montoTotal
                            };
                            eCF.Encabezado = encabezado;
                            eCF.DetallesItems.Add(new global::ECFDetallesItemsItem()
                            {
                                NumeroLinea = (short)numeroLinea,
                                IndicadorFacturacion = indicadorFacturacion,

                                NombreItem = nombreItem,
                                CantidadItem = (decimal)cantidadItem,
                                PrecioUnitarioItem = 8200,
                                MontoItem = (decimal)montoItem,

                            });

                            break;
                        case "46":
                            encabezado.IdDoc = new ECFEncabezadoIdDoc()
                            {
                                TipoeCF = tipoCf, //31
                                ENCF = encf1, //31
                                FechaVencimientoSecuencia = @"31-12-2022",
                                TipoIngresos = tipoIngresos,
                                TipoPago = TipoPagoType.Contado
                            };
                            encabezado.Emisor = new ECFEncabezadoEmisor()
                            {
                                RNCEmisor = rNCEmisor,
                                RazonSocialEmisor = razonSocialEmisor,
                                DireccionEmisor = direccionEmisor,
                                FechaEmision = fechaEmision
                            };
                            encabezado.Comprador = new ECFEncabezadoComprador()
                            {
                                RNCComprador = rNCComprador,
                                RazonSocialComprador = razonSocialComprador.ToString()
                            };
                            encabezado.Totales = new ECFEncabezadoTotales()
                            {
                                MontoGravadoTotal = montoGravadoTotal,
                                MontoTotal = montoTotal
                            };
                            eCF.Encabezado = encabezado;
                            eCF.DetallesItems.Add(new global::ECFDetallesItemsItem()
                            {
                                NumeroLinea = (short)numeroLinea,
                                IndicadorFacturacion = indicadorFacturacion,
                                NombreItem = nombreItem,
                                CantidadItem = (decimal)cantidadItem,
                                PrecioUnitarioItem = 8200,
                                MontoItem = (decimal)montoItem,

                            });

                            break;
                        default:
                            Console.WriteLine("El Comprobante no esta registrado");
                            break;

                    }
                    nombre = "E:\\" + eCF.Encabezado.Emisor.RNCEmisor + eCF.Encabezado.IdDoc.ENCF + ".xml";
                    serializer = new XmlSerializer(typeof(ECF));
                    using (var stream = new StreamWriter(nombre))
                        serializer.Serialize(stream, eCF);
                    //nombre = @"E:\E310000750120.xml";

                    Certificate = @"E:\20211129-1331448-EQHLPXY6H.p12";
                    xmlDocument = SignServices.Current.FirmarXml(nombre, Certificate, "C3r@1c0n", true, "");
                    xmlDocument.Save(nombre);
                    //@"D:\102019479E310000000001.xml";//2
                    //Captura Datos de Firma
                    CodigoSeguridad = "";
                    FechaFirma = "";
                    RncEmisor = "";
                    RncComprador = "";
                    ENCF = "";
                    FechaEmision = "";
                    MontoTotal = "";

                    try
                    {

                        XmlDocument xDoc = new XmlDocument();

                        //load up the xml from the location 
                        xDoc.Load(nombre);
                        CodigoSeguridad = HttpUtility.UrlEncode(findvalue(xDoc, "SignatureValue").Substring(1, 6));
                        FechaFirma = findvalue(xDoc, "FechaHoraFirma");
                        RncEmisor = findvalue(xDoc, "RncEmisor");
                        RncComprador = findvalue(xDoc, "RncComprador");
                        FechaEmision = findvalue(xDoc, "FechaEmision");
                        MontoTotal = findvalue(xDoc, "MontoTotal");
                        ENCF = findvalue(xDoc, "ENCF");

                    }
                    catch { }
                    Qr = String.Format("https://ecf.dgii.gov.do/TesteCF/ConsultaTimbre?RncEmisor={0}&RncComprador={1}&ENCF={2}&FechaEmision={3}&MontoTotal={4}&FechaFirma={5}&CodigoSeguridad={6}",
                        RncEmisor, RncComprador, ENCF, FechaEmision, MontoTotal, FechaFirma, CodigoSeguridad);
                    //Captura Datos de Firma
                    request.AddFile("xml", nombre, "text/xml");
                    result = client.Execute(request);
                    test = t.Deserialize<RecepcionResult>(result);
                    test.IdDoc = idDoc;
                    test.QR = Qr;
                    /*Console.WriteLine(Qr);

                    Console.WriteLine("Track ID");
                    Console.WriteLine(test.trackId);

                    Console.WriteLine("Errores");
                    Console.WriteLine(test.mensaje);
                    





                    Console.WriteLine("Estado Envio");*/
                    string estado = EstadoSolicitud(test.trackId, rest.token);
                    
                    MessageBox.Show(estado);
                    db.RecepcionResults.Add(test);
                    db.SaveChanges();
                    this.Dispose();
                   /* Console.ReadKey();
                    Console.WriteLine("Segunda lectura de Estado");
                    //estado = EstadoSolicitud(test.trackId, rest.token);
                    Console.Write(estado);*/


                    




                }

                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);

                }
            }
            static string findvalue(XmlDocument document, string name)
            {
                foreach (XmlNode node in document.DocumentElement.ChildNodes)
                {
                    foreach (XmlNode locNode in node)
                    {

                        if (locNode.HasChildNodes)
                        {
                            foreach (XmlNode subnode in locNode)
                            {
                                if (subnode.Name.ToUpper() == name.ToUpper())

                                    return subnode.InnerText;

                            }

                        }

                        if (locNode.Name.ToUpper() == name.ToUpper())
                            return locNode.InnerText;

                        if (locNode.ParentNode.Name.ToUpper() == name.ToUpper())
                            return locNode.InnerText;

                    }
                }
                return "";
            }

            static void IniciaFormulario()
            {

                Thread.CurrentThread.IsBackground = true;

                FormConsulta form = new FormConsulta();
                form.ShowDialog();
            }
            static string EstadoSolicitud(string trackid, string token)
            {
                Comp_ElectronicosEntities1 db = new Comp_ElectronicosEntities1();
                Mensaje msj = new Mensaje();
                var client = new RestClient("https://ecf.dgii.gov.do/TesteCF/ConsultaResultado/api/Consultas/Estado?TrackId=" + trackid);
                var request = new RestRequest(Method.GET);
                request.AddHeader("accept", "application/json");
                string auth = "Bearer " + token;
                request.AddHeader("Authorization", auth);
                var result = client.Execute(request);
                RestSharp.Serialization.Json.JsonDeserializer t = new RestSharp.Serialization.Json.JsonDeserializer();
                var test = t.Deserialize<EstadoEnvio>(result);
                test.Id = -1;
                msj.Id = -1;
                msj.valor = test.mensajes[0].valor;
                msj.trackid = trackid;
                db.Mensajes.Add(msj);

                db.EstadoEnvios.Add(test);
                db.SaveChanges();
                return test.estado + "-" + test.mensajes[0].valor;
            }
        }
    }
}
