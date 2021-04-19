using ASP.NETCRUDExample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCRUDExample.Controllers
{
    public class PrimeController : Controller
    {

        private static bool[] isPrime(int number)
        {
            bool[] primes = new bool[number +1]; 

            for(int i = 0; i < number; ++i)
            {
                primes[i] = true;
            }

            primes[0] = false;
            primes[1] = false;

            for (int p = 2; p * p <=number; ++p)
            {
                if(primes[p])
                {
                    for (int pp = p*p; pp <= number; pp += p)
                    {
                        primes[pp] = false;
                    }
                }
            }
            return primes;
        }

        public IActionResult Index(int id)
        {
            List<PrimeViewModel> primes = new List<PrimeViewModel>();
            var primestmb = isPrime(id);

            for (int i = 0; i <= id; ++i) //O(n * log(logn))T O(n)S
            {
                primes.Add(new PrimeViewModel()
                {
                    Number = i.ToString(),
                    IsPrime = primestmb[i]
                });
            }
            return View(primes.ToArray());
        }
    }
}
