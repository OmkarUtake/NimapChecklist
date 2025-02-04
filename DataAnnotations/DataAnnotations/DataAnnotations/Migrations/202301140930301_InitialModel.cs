﻿namespace DataAnnotations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 151));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 191));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
