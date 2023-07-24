using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppSystem
{
    public class Recipes
    {
        public static DataTable SearchRecipes(string recipe)
        {
            string sql = "select RecipeId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived, RecipeStatus, RecipePicture from Recipe r where r.RecipeName like '%" + recipe + "%' ";
            DataTable dt = SQLUtility.GetDatatable(sql);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "select r.*, u.UserName, ct.CuisineTypeName from Recipe r join users u on r.UsersId = u.UsersId join CuisineType ct on r.CuisinetypeId = ct.CuisineTypeId where r.RecipeId = " + recipeid.ToString();
            return SQLUtility.GetDatatable(sql);
        }

        public static DataTable GetUserNameList()
        {
            return SQLUtility.GetDatatable("select UsersId, UserName from Users");
        }

        public static DataTable GetCuisineTypeList()
        {
            return SQLUtility.GetDatatable("select CuisineTypeId, CuisineTypeName from CuisineType");
        }

        public static void Save(DataTable dtrecipe)
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"Update Recipe set",
                    $"UsersId = '{r["UsersId"]}',",
                    $"CuisineTypeId = '{r["CuisineTypeId"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"DateDrafted = '{r["DateDrafted"]}'",
                    $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe(UsersId, CuisineTypeId, RecipeName, Calories, DateDrafted)";
                sql += $"select '{r["UsersId"]}', '{r["CuisineTypeId"]}', '{r["RecipeName"]}', {r["Calories"]}, '{r["DateDrafted"]}'";
            }


            Debug.Print("-----------------");

            SQLUtility.ExecuteSQL(sql);
        }


        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
