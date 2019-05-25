﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Domains;
using Store.Domain.Interfaces;

namespace Store.Repository {
    public class FeatureRepository : BaseRepository<Feature>, IFeatureRepository
    {
        internal FeatureRepository(IStoreDbContext context) : base(context) {

        }
    }
}
