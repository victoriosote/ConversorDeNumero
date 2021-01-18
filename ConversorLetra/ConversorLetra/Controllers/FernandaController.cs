using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConversorLetra.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FernandaController : Controller
        {
            [HttpGet]
            public string NumeroGet(string num1)
            {
                string respuesta = ""; //1.568.768
                if (num1.Length > 7)
                { return "Numero muy grande"; }
                if (num1.Length == 0)
                {
                   return "vacio";
                }
        
                if (num1.Length == 7)
                {
                    respuesta += Millon(num1[0]);
                    respuesta += Centena(num1[1]);
                    respuesta += Decena(num1[2]);
                    if (num1[2] != '0')  //1.902.000
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[3]);
                    if (num1[1] != '0' || num1[2] != '0' || num1[3] != '0')
                    {//1.000.500
                        respuesta += " mil ";
                    }
                    //1.050.600
                    respuesta += Centena(num1[4]);
                    respuesta += Decena(num1[5]);
                    if (num1[6] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[6]);
                }

                if (num1.Length == 6)
                {

                    respuesta += Centena(num1[0]);
                    respuesta += Decena(num1[1]);
                    if (num1[2] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[2]);
                    if (num1[0] != '0' || num1[1] != '0' || num1[2] != '0')
                    {
                        respuesta += " mil ";
                    }

                    respuesta += Centena(num1[3]);
                    respuesta += Decena(num1[4]);
                    if (num1[5] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[5]);


                }

                if (num1.Length == 5)
                {


                    respuesta += Decena(num1[0]);
                    if (num1[1] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[1]);
                    if (num1[0] != '0' || num1[1] != '0')
                    {
                        respuesta += " mil ";
                    }

                    respuesta += Centena(num1[2]);
                    respuesta += Decena(num1[3]);
                    if (num1[4] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[4]);


                }

                if (num1.Length == 4)
                {

                    respuesta += Unidad(num1[0]);
                    if (num1[0] != '0')
                    {
                        respuesta += " mil ";
                    }

                    respuesta += Centena(num1[1]);
                    respuesta += Decena(num1[2]);
                    if (num1[3] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[3]);


                }


                if (num1.Length == 3)
                {

                    respuesta += Centena(num1[0]);
                    respuesta += Decena(num1[1]);
                    if (num1[2] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[2]);


                }

                if (num1.Length == 2)
                {

                    respuesta += Decena(num1[0]);
                    if (num1[1] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[1]);


                }

                if (num1.Length == 1 && num1!="0")
                {
                    respuesta += Unidad(num1[0]);
                }
                if (num1.Length == 1 && num1 == "0")
                    return "cerooooooooooooo XD memes loayza";
                

            return respuesta;


            }


            private string Millon(char x)
            {
                if (x == '1')
                { return "Millon "; }
                if (x == '2')
                { return "Dos Millones "; }
                if (x == '3')
                { return "Tres Millones "; }
                if (x == '4')
                { return "Cuatro Millones "; }
                if (x == '5')
                { return "Cinco Millones "; }
                if (x == '6')
                { return "Seis Millones "; }
                if (x == '7')
                { return "Siete Millones "; }
                if (x == '8')
                { return "Ocho Millones "; }
        
                return "Nueve Millones ";

            }

            private string Centena(char x)
            {

                if (x == '1')
                { return "Cien "; }
                if (x == '2')
                { return "Doscientos "; }
                if (x == '3')
                { return "Trescientos "; }
                if (x == '4')
                { return "Cuatrocientos "; }
                if (x == '5')
                { return "Quinientos "; }
                if (x == '6')
                { return "Seiscientos "; }
                if (x == '7')
                { return "Sietecientos "; }
                if (x == '8')
                { return "Ochocientos "; }
                if (x == '9')
                { return "Novecientos "; }
                return " ";

            }

            private string Decena(char x)
            {
                if (x == '1')
                { return "Diez "; }
                if (x == '2')
                { return "Veinte "; }
                if (x == '3')
                { return "Treinta "; }
                if (x == '4')
                { return "Cuarenta "; }
                if (x == '5')
                { return "Cincuenta "; }
                if (x == '6')
                { return "Sesenta "; }
                if (x == '7')
                { return "Setenta "; }
                if (x == '8')
                { return "Ochenta "; }
                if (x == '9')
                { return "Noventa "; }
                return " ";
            }

            private string Unidad(char x)
            {
                if (x == '1')
                { return "Uno"; }
                if (x == '2')
                { return "Dos"; }
                if (x == '3')
                { return "Tres"; }
                if (x == '4')
                { return "Cuatro"; }
                if (x == '5')
                { return "Cinco"; }
                if (x == '6')
                { return "Seis"; }
                if (x == '7')
                { return "Siete"; }
                if (x == '8')
                { return "Ocho"; }
                if (x == '9')
                { return "Nueve"; }
                return " ";
            }





            [HttpPost]
            public string NumeroPost([FromHeader] string num1)
            {
                string respuesta = "";

                if (num1.Length > 7)
                { return "Numero muy grande"; }
                if (num1.Length == 0)
                { return "Vacio"; }
                if (num1.Length == 7)
                {
                    respuesta += Millon(num1[0]);
                    respuesta += Centena(num1[1]);
                    respuesta += Decena(num1[2]);
                    if (num1[2] != '0')
                    { respuesta += " y"; }
                    respuesta += Unidad(num1[3]);
                    if (num1[1] != '0' || num1[2] != '0' || num1[3] != '0')
                    {
                        respuesta += " mil ";
                    }

                    respuesta += Centena(num1[4]);
                    respuesta += Decena(num1[5]);
                    if (num1[6] != '0')
                    { respuesta += " y "; }
                    respuesta += Unidad(num1[6]);


                }

                if (num1.Length == 6)
                {

                    respuesta += Centena(num1[0]);
                    respuesta += Decena(num1[1]);
                    if (num1[1] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[2]);
                    if (num1[0] != '0' || num1[1] != '0' || num1[2] != '0')
                    {
                        respuesta += " mil ";
                    }

                    respuesta += Centena(num1[3]);
                    respuesta += Decena(num1[4]);
                    if (num1[5] != '0')
                    { respuesta += " y"; }
                    respuesta += Unidad(num1[5]);


                }

                if (num1.Length == 5)
                {


                    respuesta += Decena(num1[0]);
                    if (num1[0] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[1]);
                    if (num1[0] != '0' || num1[1] != '0')
                    {
                        respuesta += " mil ";
                    }

                    respuesta += Centena(num1[2]);
                    respuesta += Decena(num1[3]);
                    if (num1[4] != '0')
                    { respuesta += " y"; }
                    respuesta += Unidad(num1[4]);


                }

                if (num1.Length == 4)
                {

                    respuesta += Unidad(num1[0]);
                    if (num1[0] != '0')
                    {
                        respuesta += " mil ";
                    }

                    respuesta += Centena(num1[1]);
                    respuesta += Decena(num1[2]);
                    if (num1[3] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[3]);


                }


                if (num1.Length == 3)
                {

                    respuesta += Centena(num1[0]);
                    respuesta += Decena(num1[1]);
                    if (num1[2] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[2]);


                }

                if (num1.Length == 2)
                {

                    respuesta += Decena(num1[0]);
                    if (num1[1] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[1]);


                }

                if (num1.Length == 1)
                {
                    respuesta += Unidad(num1[0]);


                }


                return respuesta;
            }




        }
}

