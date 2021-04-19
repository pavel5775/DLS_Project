using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer
{
    public static class SampleData
    {
        public static void InitData(EFDBContext context)
        {
            if (!context.Directories.Any())
            {
                context.Directories.Add(new Directory()
                {
                    Title = "First chapter", 
                    Html = "<h4>Placeholder1<h4>"
                });

                context.Directories.Add(new Directory()
                {
                    Title = "Second chapter",
                    Html = "<h4>Placeholder2<h4>"
                });

                context.Directories.Add(new Directory()
                {
                    Title = "Third chapter",
                    Html = "<h4>Placeholder3<h4>"
                });

                context.SaveChanges();

                if (!context.Materials.Any())
                {
                    context.Materials.Add(new Material()
                    {
                        Title = "Paragraph11",
                        Html = "About11",
                        DirectoryId = 1
                    }); 
                    context.Materials.Add(new Material()
                    {
                        Title = "Paragraph12",
                        Html = "About12",
                        DirectoryId = 1
                    });

                    context.Materials.Add(new Material()
                    {
                        Title = "Paragraph21",
                        Html = "About21",
                        DirectoryId = 2
                    }); 
                    context.Materials.Add(new Material()
                    {
                        Title = "Paragraph22",
                        Html = "About22",
                        DirectoryId = 2
                    });

                    context.Materials.Add(new Material()
                    {
                        Title = "Paragraph31",
                        Html = "About31",
                        DirectoryId = 3
                    });
                    context.Materials.Add(new Material()
                    {
                        Title = "Paragraph32",
                        Html = "About32",
                        DirectoryId = 3
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
