﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class LoadBalancer

    {
        private static LoadBalancer _instance;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        // Lock synchronization object

        private static object syncLock = new object();

        // Constructor (protegido)

        protected LoadBalancer()
        {
            // Lista de servidores disponibles

            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Support multithreaded applications through

            // 'Double checked locking' pattern which (once

            // the instance exists) avoids locking each

            // time the method is invoked

            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }

        // Simple, pero efectivo random server

        public string Server
        {
            get

            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}
