//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
//     author MEIAM
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace Meiam.System.Model
{
    ///<summary>
    ///用户角色
    ///</summary>
    [SugarTable("Sys_UserRole")]
    public class Sys_UserRole
    {
          public Sys_UserRole()
          {
          }

           /// <summary>
           /// 描述 : UUID 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "UUID")]           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// 描述 : 用户ID 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "用户ID")]           
           public string UserID {get;set;}

           /// <summary>
           /// 描述 : 角色ID 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "角色ID")]           
           public string RoleID {get;set;}

    }
}