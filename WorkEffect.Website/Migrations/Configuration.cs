using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
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
            //if (Debugger.IsAttached == false)
            //    Debugger.Launch();

            var page = new CmsPage
            {
                Name = "Init",
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
                                            Name = "Init",
                                            CmsResources = new List<CmsResource>
                                            {
                                                new CmsResource
                                                {
                                                    Text = "Bla"
                                                }
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
