﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.FileDAO
{
    public class FileGenresDAO
    {
        public FileGenresDAO()
        { }

        //private static GenresDAO? instance;
        //private static readonly object instanceLock = new object();

        //public static GenresDAO Instance
        //{
        //    get
        //    {
        //        lock (instanceLock)
        //        {
        //            if (instance == null)
        //            {
        //                instance = new GenresDAO();
        //            }
        //            return instance;
        //        }
        //    }
        //}

        public IEnumerable<Genre> GetGenres()
        {
            return Cache.Genres;
        }
    }
}