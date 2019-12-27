using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //这个是属性的特性,一般用于规定该属性在数据库当中所用的约束
using System.ComponentModel.DataAnnotations.Schema; // 这个是用于规定当前字符串的数据类型的nvarchar或者varchar
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Grades
    {
        [Key]//这个特性是 Primary key 他是主键约束
        public int Id { get; set; }

        [StringLength(255)] //这个是设定字符串长度
        [Column(TypeName ="varchar")]
        public string Title { get; set; }
    }
}