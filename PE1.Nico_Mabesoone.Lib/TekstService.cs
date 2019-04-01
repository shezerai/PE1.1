﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace PE1.Nico_Mabesoone.Lib
{
    class TekstService
    {
        public  async Task<String> GetTekst(IEnumerable<String> input, TekstMode mode)
        {
            if(mode == TekstMode.Normal)
            {
                 return input.ToString();
            }
            else if (mode ==TekstMode.Reverse)
            {
                String teruggave = input.ToString();
                char[] welp = teruggave.ToCharArray();
                return new String(welp);
            }
            else if(mode == TekstMode.Ascii)
            {
                HttpClient eenClient = new HttpClient();
                HttpResponseMessage eenResponse = new HttpResponseMessage();
                 eenResponse= await eenClient.GetAsync("http://artii.herokuapp.com/make?text=" + input);
                return await eenResponse.Content.ReadAsStringAsync();
            }
           
        }
        

        
    }
}
