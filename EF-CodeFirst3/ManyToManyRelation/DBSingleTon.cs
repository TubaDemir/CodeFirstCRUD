namespace ManyToManyRelation
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class DBSingleTon : DbContext
    {
        // Your context has been configured to use a 'DBSingleTon' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ManyToManyRelation.DBSingleTon' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBSingleTon' 
        // connection string in the application configuration file.
        public DBSingleTon()
            : base("name=DBSingleTon")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Egitmen> Egitmenler { get; set; }
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    public class Egitmen
    {
        public Egitmen()
        {
            this.Ogrenci = new HashSet<Ogrenci>();
        }
        public int EgitmenID { get; set; }
        public string EgitmenAdi { get; set; }
        public string EgitmenSoyadi { get; set; }
      //  public int OgrenciID { get; set; }

        public virtual ICollection<Ogrenci> Ogrenci { get; set; }

        //
    }

    public class Ogrenci
    {
        public Ogrenci()
        {
            this.Egitmen = new HashSet<Egitmen>();  //Initilization dýr ICOLLECTÝON oldugu ýcýn kullandýk yoksa gerek yok.
        }
        public int OgrenciID { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }

     //   public int EgitmenID { get; set; }
        public virtual ICollection<Egitmen> Egitmen { get; set; } //many to many iliþký oldugu ýcýn ICOLLECTION kullanýlýr.
    }



}