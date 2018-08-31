using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 示例3_3
{
    //枚举定义性别
    public enum Genders
    {
        Female = 0,
        Male = 1
    }
    public class Person
    {
        private String _Name;//姓名字段
        public String Name//姓名属性
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value.Trim();
            }
        }
        private int _Age;//年龄字段
        public int Age//年龄属性
        {
            get
            {
                return this._Age;
            }
            set
            {
                //如果年龄超出1-120，则用默认值20
                if ((value > 120) || (value < 1))
                    this._Age = 20;
                else
                    this._Age = value;
            }
        }
        private Genders _Gender;
        public Genders Gender
        {
            get
            {
                return this._Gender;
            }
            set
            {
                this._Gender = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person();
            aPerson.Name = "zhangsan";
            aPerson.Gender = Genders.Male;
            aPerson.Age = 30;
            PrintPerson(aPerson);
        }
        static void PrintPerson(Person aPerson)
        {
            System.Console.WriteLine("姓名：{0}性别：{1}年龄：{2}", aPerson.Name, aPerson.Gender, aPerson.Age);
        }
    }
}
