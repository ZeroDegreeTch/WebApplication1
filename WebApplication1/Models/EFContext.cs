using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EFContext : DbContext
    {
        public EFContext()
            :base("DbCon") //这个是调用我们父类的构造,并且把我们连接数据库的语句存放在这里
        {

        }

        //封装我们的数据表,DbSet 这个是数据库集合,里面用于存放我们的数据表,它是带有泛型的
        //泛型内容就是我们数据表的内容(我们写封装的类)
        public DbSet<Grades> Grades { get; set; }


    }
}