﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using WindowsFormsApp1.modelo;
using App.vistas;
using static Community.CsharpSqlite.Sqlite3;
using DateTime = System.DateTime;

namespace App.SQL
{
    public class SQLConnector
    {

        public void showValuesGrid(DataGridView dataGridView1)
        {
            using (netAssistantsEntities db = new netAssistantsEntities())
            {
                dataGridView1.DataSource = db.Vehiculo.ToList();
            }
        }

        public void exportDataXML(int op)
        {
            switch (op)
            {
                case 1:
                    //exportar XML Conductor
                    using (netAssistantsEntities db = new netAssistantsEntities())
                    {

                        try
                        {
                            XElement DBtoXML = new XElement("Lista",
                            (from tbl in db.Conductor
                             select new
                             {
                                 tbl.id_conductor,
                                 tbl.nombre,
                                 tbl.apellidos,
                                 tbl.domicilio,
                                 tbl.permiso,
                                 tbl.disponibilidad
                             }).ToList().Select(x => new XElement("Conductor",
                                                     new XElement("id_conductor", x.id_conductor),
                                                     new XElement("nombre", x.nombre),
                                                     new XElement("apellido", x.apellidos),
                                                     new XElement("domicilio", x.domicilio),
                                                     new XElement("permiso", x.permiso),
                                                     new XElement("disponibilidad", x.disponibilidad)
                                                     )));
                            FileStream xmlFile = File.OpenWrite(@"/Flota/python/conductores.xml");
                            byte[] xmlBytes = Encoding.UTF8.GetBytes(DBtoXML.ToString());
                            xmlFile.Write(xmlBytes, 0, xmlBytes.Length);
                            xmlFile.Close();

                        }
                        catch (Exception error)
                        {

                            MessageBox.Show("Error al cargar el XML " + error.Message);

                        }
                    }
                    break;
                case 2:
                    //exportar XML Mercancia
                    using (netAssistantsEntities _db = new netAssistantsEntities())
                    {
                        try
                        {
                            XElement DBtoXML = new XElement("Lista",
                            (from tbl in _db.Mercancia
                             select new
                             {
                                 tbl.id_producto,
                                 tbl.nombre,
                                 tbl.volumenProducto,

                             }).ToList().Select(x => new XElement("Mercancia",
                                             new XElement("id_producto", x.id_producto),
                                             new XElement("nombre", x.nombre),
                                             new XElement("volumenProducto", x.volumenProducto)
                                             )));
                            FileStream xmlFile = File.OpenWrite(@"/Flota/python/mercancias.xml");
                            byte[] xmlBytes = Encoding.UTF8.GetBytes(DBtoXML.ToString());
                            xmlFile.Write(xmlBytes, 0, xmlBytes.Length);
                            xmlFile.Close();

                        }
                        catch (Exception error)
                        {

                            MessageBox.Show("Error al cargar el XML " + error.Message);

                        }

                    }
                    break;
                case 3:
                    //exportar XML Vehiculo
                    using (netAssistantsEntities _db = new netAssistantsEntities())
                    {
                        try
                        {
                            XElement DBtoXML = new XElement("Lista",
                            (from tbl in _db.Vehiculo
                             select new
                             {
                                 tbl.id_vehiculo,
                                 tbl.marca,
                                 tbl.tipoVehiculo,
                                 tbl.disponibilidadVehiculo,
                                 tbl.volumenGasolina,
                                 tbl.estado,

                             }).ToList().Select(x => new XElement("Vehiculo",
                                             new XElement("id_vehiculo", x.id_vehiculo),
                                             new XElement("marca", x.marca),
                                             new XElement("tipoVehiculo", x.tipoVehiculo),
                                             new XElement("disponibilidadVehiculo", x.disponibilidadVehiculo),
                                             new XElement("volumenGasolina", x.volumenGasolina),
                                             new XElement("estado", x.estado)
                                             )));
                            FileStream xmlFile = File.OpenWrite(@"/Flota/python/vehiculos.xml");
                            byte[] xmlBytes = Encoding.UTF8.GetBytes(DBtoXML.ToString());
                            xmlFile.Write(xmlBytes, 0, xmlBytes.Length);
                            xmlFile.Close();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Error al cargar el XML " + error.Message);
                        }
                    }
                    break;
                case 4:
                    //exportar XML GestionRuta
                    using (netAssistantsEntities _db = new netAssistantsEntities())
                    {
                        try
                        {
                            XElement DBtoXML = new XElement("Lista",
                            (from tbl in _db.GestionRuta
                             select new
                             {
                                 tbl.id_GestionRuta,
                                 tbl.volumen,
                                 tbl.fechaEnvio,
                                 tbl.id_conductor,
                                 tbl.id_mercancia,
                                 tbl.id_vehiculo,
                                 tbl.id_ruta,
                             }).ToList().Select(x => new XElement("GestionRuta",
                                             new XElement("id_GestionRuta", x.id_GestionRuta),
                                             new XElement("volumen", x.volumen),
                                             new XElement("fechaEnvio", x.fechaEnvio),
                                             new XElement("id_conductor", x.id_conductor),
                                             new XElement("id_mercancia", x.id_mercancia),
                                             new XElement("id_vehiculo", x.id_vehiculo),
                                             new XElement("id_ruta", x.id_ruta)
                                             )));
                            FileStream xmlFile = File.OpenWrite(@"/Flota/python/GestionRuta.xml");
                            byte[] xmlBytes = Encoding.UTF8.GetBytes(DBtoXML.ToString());
                            xmlFile.Write(xmlBytes, 0, xmlBytes.Length);
                            xmlFile.Close();

                        }
                        catch (Exception error)
                        {

                            MessageBox.Show("Error al cargar el XML " + error.Message);

                        }
                    }
                    break;
                case 5:
                    //exportar XML Ruta
                    /*using (netAssistantsEntities _db = new netAssistantsEntities())
                    {
                        try
                        {
                            XElement DBtoXML = new XElement("Lista",
                            (from tbl in _db.Ruta
                                select new
                                {
                                    tbl.id_ruta,
                                    tbl.origen_ruta,
                                    tbl.destino_ruta,
                                    tbl.repostar_gasolina,
                                    tbl.fecha_ruta,
                                    tbl.duracion,
                                    tbl.precio_repostaje,
                                    tbl.kms_ruta,

                                }).ToList().Select(x => new XElement("Ruta",
                                                        new XElement("id_ruta", x.id_ruta),
                                                        new XElement("origen_ruta", x.origen_ruta),
                                                        new XElement("destino_ruta", x.destino_ruta),
                                                        new XElement("repostar_gasolina", x.repostar_gasolina),
                                                        new XElement("fecha_ruta", x.fecha_ruta),
                                                        new XElement("precio_repostaje", x.precio_repostaje),
                                                        new XElement("kms_ruta", x.kms_ruta)
                                                        )));
                            FileStream xmlFile = File.OpenWrite(@"rutas.xml");
                            byte[] xmlBytes = Encoding.UTF8.GetBytes(DBtoXML.ToString());
                            xmlFile.Write(xmlBytes, 0, xmlBytes.Length);
                            xmlFile.Close();
                            MessageBox.Show("El XML se ha generado correctamente");

                        }
                        catch (Exception error)
                        {

                        MessageBox.Show("Error al cargar el XML " + error.Message);

                        }

                    }*/
                    break;
            }

        }

        public void importDataXML(int op)
        {
            switch (op)
            {
                case 1:
                    //Importacion de datos de XML Conductor
                    XDocument xDoc = XDocument.Load(@"/Flota/python/conductores.xml");
                    try
                    {

                        List<Conductor> conductores = xDoc.Descendants("Conductor").Select
                        (conductor =>
                        new Conductor
                        {
                            id_conductor = Int32.Parse(conductor.Element("id_conductor").Value),
                            nombre = conductor.Element("nombre").Value,
                            apellidos = conductor.Element("apellido").Value,
                            domicilio = conductor.Element("domicilio").Value,
                            permiso = conductor.Element("permiso").Value,
                            disponibilidad = bool.Parse(conductor.Element("disponibilidad").Value)
                        }
                        ).ToList();

                        using (netAssistantsEntities db = new netAssistantsEntities())
                        {
                            foreach (var i in conductores)
                            {
                                var v = db.Conductor.Where(a => a.id_conductor.Equals(i.id_conductor)).FirstOrDefault();
                                if (v != null)
                                {
                                    v.id_conductor = i.id_conductor;
                                    v.nombre = i.nombre;
                                    v.apellidos = i.apellidos;
                                    v.domicilio = i.domicilio;
                                    v.permiso = i.permiso;
                                    v.disponibilidad = (bool)i.disponibilidad;
                                    //MessageBox.Show("El Conductor " + v.id_conductor + " esta duplicado");
                                }
                                else
                                {
                                    db.Conductor.Add(i);
                                }
                            }
                            MessageBox.Show("Se ha cargado el XML CONDUCTOR");
                            db.SaveChanges();
                        }

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error al cargar el XML" + err.Message);
                    }
                    break;
                case 2:
                    //Importacion de datos de XML Mercancia
                    XDocument xDocM = XDocument.Load(@"/Flota/python/mercancias.xml");
                    try
                    {

                        List<Mercancia> mercancias = xDocM.Descendants("Mercancia").Select
                        (mercancia =>
                        new Mercancia
                        {
                            id_producto = Int32.Parse(mercancia.Element("id_producto").Value),
                            nombre = mercancia.Element("nombre").Value,
                            volumenProducto = float.Parse(mercancia.Element("volumenProducto").Value)
                        }
                        ).ToList();

                        using (netAssistantsEntities db = new netAssistantsEntities())
                        {
                            foreach (var i in mercancias)
                            {
                                var v = db.Mercancia.Where(a => a.id_producto.Equals(i.id_producto)).FirstOrDefault();
                                if (v != null)
                                {
                                    v.id_producto = i.id_producto;
                                    v.nombre = i.nombre;
                                    v.volumenProducto = i.volumenProducto;
                                    //MessageBox.Show("La Mercancia " + v.id_producto + " esta duplicada");
                                }
                                else
                                {
                                    db.Mercancia.Add(i);
                                }
                            }
                            MessageBox.Show("Se ha cargado el XML MERCANCIA");
                            db.SaveChanges();
                        }

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error al cargar el XML" + err);
                    }
                    break;
                case 3:
                    //Importar Vehiculos
                    XDocument xDocV = XDocument.Load(@"/Flota/python/vehiculos.xml");
                    try
                    {
                        List<Vehiculo> vehiculos = xDocV.Descendants("Vehiculo").Select
                        (vehiculo =>
                        new Vehiculo
                        {

                            id_vehiculo = Int32.Parse(vehiculo.Element("id_vehiculo").Value),
                            marca = vehiculo.Element("marca").Value,
                            tipoVehiculo = vehiculo.Element("tipoVehiculo").Value,
                            disponibilidadVehiculo = bool.Parse(vehiculo.Element("disponibilidadVehiculo").Value),
                            volumenGasolina = float.Parse(vehiculo.Element("volumenGasolina").Value),
                            estado = bool.Parse(vehiculo.Element("estado").Value)
                        }
                        ).ToList();

                        using (netAssistantsEntities db = new netAssistantsEntities())
                        {
                            foreach (var i in vehiculos)
                            {
                                var v = db.Vehiculo.Where(a => a.id_vehiculo.Equals(i.id_vehiculo)).FirstOrDefault();
                                if (v != null)
                                {
                                    v.id_vehiculo = i.id_vehiculo;
                                    v.marca = i.marca;
                                    v.tipoVehiculo = i.tipoVehiculo;
                                    v.disponibilidadVehiculo = i.disponibilidadVehiculo;
                                    v.volumenGasolina = i.volumenGasolina;
                                    v.estado = (bool)i.estado;
                                    //MessageBox.Show("El Vehiculo " + v.id_vehiculo + " esta duplicado");
                                }
                                else
                                {
                                    db.Vehiculo.Add(i);
                                }
                            }
                            MessageBox.Show("Se ha cargado el XML Vehiculo");
                            db.SaveChanges();
                        }

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error al cargar el XML" + err.Message);
                    }
                    break;
                case 4:
                    //Importar Vehiculos
                    XDocument xDocP = XDocument.Load(@"/Flota/python/GestionRuta.xml");
                    try
                    {
                        List<GestionRuta> Grutas = xDocP.Descendants("GestionRuta").Select
                        (gr =>
                        new GestionRuta
                        {

                            id_GestionRuta = Int32.Parse(gr.Element("id_GestionRuta").Value),
                            volumen = double.Parse(gr.Element("volumen").Value),
                            fechaEnvio = DateTime.Parse(gr.Element("fechaEnvio").Value),
                            id_conductor = Int32.Parse(gr.Element("id_conductor").Value),
                            id_mercancia = Int32.Parse(gr.Element("id_mercancia").Value),
                            id_vehiculo = Int32.Parse(gr.Element("id_vehiculo").Value),
                            id_ruta = Int32.Parse(gr.Element("id_ruta").Value)
                            
                        }
                        ).ToList();

                        using (netAssistantsEntities db = new netAssistantsEntities())
                        {
                            foreach (var i in Grutas)
                            {
                                var v = db.GestionRuta.Where(a => a.id_GestionRuta.Equals(i.id_GestionRuta)).FirstOrDefault();
                                if (v != null)
                                {
                                    v.id_GestionRuta = i.id_GestionRuta;
                                    v.volumen = i.volumen;
                                    v.fechaEnvio = i.fechaEnvio;
                                    v.id_conductor = i.id_conductor;
                                    v.id_mercancia = i.id_mercancia;
                                    v.id_vehiculo = i.id_vehiculo;
                                    v.id_ruta = i.id_ruta;
                                    //MessageBox.Show("El Vehiculo " + v.id_vehiculo + " esta duplicado");
                                }
                                else
                                {
                                    db.GestionRuta.Add(i);
                                }
                            }
                            MessageBox.Show("Se ha cargado el XML Pedidos");
                            db.SaveChanges();
                        }

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error al cargar el XML" + err.Message);
                    }
                    break;
                case 5:
                    //Importacion de datos de XML Rutas
                    /*XDocument xDocR = XDocument.Load(@"rutas.xml");
                    try
                    {

                        List<Ruta> rutas = xDocR.Descendants("Ruta").Select
                        (ruta =>
                        new Ruta
                        {
                            id_ruta = Int32.Parse(ruta.Element("id_ruta").Value),
                            origen_ruta = ruta.Element("origen_ruta").Value,
                            destino_ruta = ruta.Element("destino_ruta").Value,
                            repostar_gasolina = bool.Parse(ruta.Element("repostar_gasolina").Value),
                            fecha_ruta = DateTime.Parse(ruta.Element("fecha_ruta").Value),
                            duracion = DateTime.Parse(ruta.Element("duracion").Value),
                            precio_repostaje = float.Parse(ruta.Element("precio_repostaje").Value),
                            kms_ruta = float.Parse(ruta.Element("kms_ruta").Value)
                        }
                        ).ToList();


                        using (netAssistantsEntities db1 = new netAssistantsEntities())
                        {
                            foreach (var i in rutas)
                            {
                                var v = db1.Ruta.Where(a => a.id_ruta.Equals(i.id_ruta)).FirstOrDefault();
                                if (v != null)
                                {
                                    v.id_ruta = i.id_ruta;
                                    v.origen_ruta = i.origen_ruta;
                                    v.destino_ruta = i.destino_ruta;
                                    v.repostar_gasolina = (bool)i.repostar_gasolina;
                                    v.fecha_ruta = i.fecha_ruta;
                                    v.duracion = i.duracion;
                                    v.precio_repostaje = (float)i.precio_repostaje;
                                    v.kms_ruta = (float)i.kms_ruta;
                                }
                                else
                                {
                                    db1.Ruta.Add(i);
                                }
                            }
                            MessageBox.Show("Se ha cargado el XML RUTA");
                            db1.SaveChanges();
                        }

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error al cargar el XML" + err.Message);
                    }*/
                    MessageBox.Show("Se ha cargado el XML RUTA");
                    break;
            }
        }
    }

}