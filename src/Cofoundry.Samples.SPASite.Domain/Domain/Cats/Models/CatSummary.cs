﻿using Cofoundry.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofoundry.Samples.SPASite.Domain
{
    /// <summary>
    /// The difference between the CatDetails and CatSummary model
    /// is small, but it illustrates how the CQS lets us tailor 
    /// models returned from queries to fit different situations.
    /// </summary>
    public class CatSummary
    {
        public int CatId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int TotalLikes { get; set; }

        public ImageAssetRenderDetails MainImage { get; set; }
    }
}
