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

        //特性是我们通过 Models创建数据库而用的约束内容
        // EF框架 的 Code First写法(外面的主流写法)
        //1. 需要我们安装EF框架,我们需要找到工具--> NuGet 管理器 --> 程序包管理控制台
        //他相当于我们电脑当中cmd界面,我们需要在里面添加 命令行 实现导入 EF框架
        // install-package EntityFramework
        //2. 我们需要在Models里面创建一个新的类,用于当作连接数据库之后操作上下文类
        // context   --> DbContext ,需要我们继承 DbContext这个类
        //3. 我们通过下面的三行命令实现创建数据库和数据表
        //(1) enable-migrations    检测我们创建数据库的环境
        //(2) add-migration 我们自己起的名字   这个是我们创建数据库更新文件,名字是数据迁移时候的记录名
        //(3) Update-Database     更新数据库
    }
}