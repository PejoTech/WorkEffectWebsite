using System.Collections.Generic;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WorkEffect.Website.Controllers;
using WorkEffect.Website.Data;
using WorkEffect.Website.Models;
using WorkEffect.Website.Types;

namespace WorkEffect.Website.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WorkEffect.Website.Data.WorkEffectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WorkEffect.Website.Data.WorkEffectDbContext";
        }

        protected override void Seed(WorkEffect.Website.Data.WorkEffectDbContext context)
        {
            var page = new CmsPage
            {
                CmsGrid = new CmsGrid
                {
                    CmsRows = new List<CmsRow>
                    {
                        new CmsRow
                        {
                            CmsCells = new List<CmsCell>
                            {
                                new CmsCell
                                {
                                    CmsParts = new List<CmsPart>
                                    {
                                        new CmsPart
                                        {
                                            CmsResources = new List<CmsResource>
                                            {

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            context.CmsPages.Add(page);
        }
    }
}
