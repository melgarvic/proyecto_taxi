﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = Broker;
using EN = Entities;
namespace Controllers
{
    public class Produccion
    {

        //Entidades para el manejo de la persistencia
        BR.taxareEntities db;
        Conductores conductoresController;
        Taxis taxisController;

        public Produccion()
        {

            db = new BR.taxareEntities();
            conductoresController = new Conductores();
            taxisController = new Taxis();
        }

        public bool CrearProduccion(EN.Produccion produccion, string cedula) {

            bool resultado = false;

            try
            {
                BR.Produccion produccionAGuardar = new BR.Produccion();
                produccionAGuardar.final = produccion.final;
                produccionAGuardar.id_taxista = Convert.ToInt32(conductoresController.MostarConductorxCedula(cedula));
                produccionAGuardar.inicio = produccion.inicio;
                produccionAGuardar.placa = produccion.placa;
                produccionAGuardar.valor = produccion.producido;

                db.Produccion.Add(produccionAGuardar);
                db.SaveChanges();

                resultado = true;
                return resultado;
            }
            catch (Exception)
            {
                return resultado;
                throw;
            }

            

        }

        public bool ActualzarProduccion(EN.Produccion produccion)
        {

            bool resultado = false;

            try
            {
                BR.Produccion actualizar = db.Produccion.Where(x=>x.id == produccion.id).FirstOrDefault();
                actualizar.final = produccion.final;
                actualizar.id_taxista = Convert.ToInt32(conductoresController.MostarConductorxNombre(produccion.conductor).id);
                actualizar.inicio = produccion.inicio;
                actualizar.placa = produccion.placa;
                actualizar.valor = produccion.producido;
                db.SaveChanges();

                resultado = true;
                return resultado;
            }
            catch (Exception)
            {
                return resultado;
                throw;
            }



        }

        public bool EliminarProduccrion(int idaEliminar)
        {

            bool resultado = false;
            try
            {

               
                BR.Produccion eliminar = db.Produccion.Where(x => x.id == idaEliminar).FirstOrDefault();
                db.Produccion.Remove(eliminar);
                db.SaveChanges();
           
                return resultado;
            }
            catch (Exception)
            {
                return resultado;

            }

        }

        public EN.Produccion ObtenerProduccionPorId(int id)
        {

            try
            {

                EN.Produccion entidad = new EN.Produccion();
                BR.Produccion obtenida = db.Produccion.Where(x => x.id == id).FirstOrDefault();
                //Mapeo clase a clase
                // Difference in days, hours, and minutes.
                TimeSpan ts = obtenida.inicio - obtenida.final;
                int dias = ts.Days; 
                entidad.conductor = conductoresController.MostarConductor(obtenida.id_taxista).nombre;
                entidad.dias = dias;
                entidad.final = obtenida.final;
                entidad.id = obtenida.id;
                entidad.inicio = obtenida.inicio;
                entidad.placa = obtenida.placa;
                entidad.producido = obtenida.valor;

                return entidad;
            }
            catch (Exception)
            {
                return null;
               
            }

        }

        public List<EN.Produccion> ListaProducciones() {

            List<EN.Produccion> toReturn = new List<EN.Produccion>();

            var query = db.Produccion.ToList();

            foreach (var item in query)
            {
                EN.Produccion entidad = new EN.Produccion();
                //Mapeo clase a clase
                // Difference in days, hours, and minutes.
                TimeSpan ts = item.inicio - item.final;
                int dias = ts.Days;
                entidad.conductor = conductoresController.MostarConductor(item.id_taxista).nombre;
                entidad.dias = dias;
                entidad.final = item.final;
                entidad.id = item.id;
                entidad.inicio = item.inicio;
                entidad.placa = item.placa;
                entidad.producido = item.valor;

                toReturn.Add(entidad);

            }

            return toReturn;

        }

    }
}