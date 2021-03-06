﻿using System.Collections.Generic;
using System.Linq;
using technoApi.Models;
using technoApi.Models.Profile;

namespace technoApi.Repositories
{
    public class TitleRepository: EntityBaseRepository<Title>, ITitleRepository
    {
        public TitleRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}