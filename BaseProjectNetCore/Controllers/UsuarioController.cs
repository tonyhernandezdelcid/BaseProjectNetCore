using BaseProjectNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BaseProjectNetCore.Controllers
{
    public class UsuarioController : Controller
    {

        HttpClientHandler _clientHandler = new HttpClientHandler();


        Usuario _oUsuario = new Usuario();
        List<Usuario> _oUsuarios = new List<Usuario>();

        public UsuarioController ()
        {
            _clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            

        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<List<Usuario>> GetAllUsers()
        {

            _oUsuarios = new List<Usuario>();

            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("http://localhost:8080/baseprojectapi/consultausuarios"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _oUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(apiResponse);


                }
            }
                return _oUsuarios;
        }





        [HttpGet]
        public async Task<Usuario> GetById(string userId)
        {

            _oUsuario = new Usuario();

            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("http://localhost:8080/baseprojectapi/verusrindividual/"+userId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _oUsuario = JsonConvert.DeserializeObject<Usuario>(apiResponse);


                }
            }
            return _oUsuario;
        }



        [HttpPost]
        public async Task<Boolean> AddUser(Usuario user)
        {
            Boolean respu = false;
            

            using (var httpClient = new HttpClient(_clientHandler))
            {

                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");



                using (var response = await httpClient.PostAsync("http://localhost:8080/baseprojectapi/crearusuario", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    respu = JsonConvert.DeserializeObject<Boolean>(apiResponse);


                }
            }
            return respu;
        }




        [HttpPost]
        public async Task<Boolean> updateUser(Usuario user)
        {
            Boolean respu = false;


            using (var httpClient = new HttpClient(_clientHandler))
            {

                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");



                using (var response = await httpClient.PutAsync("http://localhost:8080/baseprojectapi/modificarusuario", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    respu = JsonConvert.DeserializeObject<Boolean>(apiResponse);


                }
            }
            return respu;
        }



        [HttpDelete]
        public async Task<Boolean> deleteUser(string userID)
        {
            Boolean respu = false;


            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:8080/baseprojectapi/eliminausuario/"+userID))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    respu = JsonConvert.DeserializeObject<Boolean>(apiResponse);
                }
            }
            return respu;
        }
    }
}
