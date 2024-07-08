﻿
using System.Reflection;
using System.Xml.Serialization;

namespace CheckClass
{
    public sealed class CheckType
    {
        public CheckType(Type type)
        {
            _type = type;
        }

        public void GetInfoType()
        {
            GetStatsType();
            GetListConstructors();
            GetListProperties();
            GetListMethods();
            GetListInterfaces();
            GetListFields();
            GetListEvents();
        }

        public void GetInfoType(bool isViewConstructors, bool isViewProperties, bool isViewMethods, bool isViewInterfaces, bool isViewFields, bool isViewEvents)
        {
            GetStatsType();
            if (isViewConstructors) GetListConstructors();
            if (isViewProperties) GetListProperties();
            if (isViewMethods) GetListMethods();
            if (isViewInterfaces) GetListInterfaces();
            if (isViewFields) GetListFields();
            if (isViewEvents) GetListEvents();
        }

        private void GetStatsType()
        {
            Console.WriteLine($"Name : {_type.Name}");
            Console.WriteLine($"Namespace : {_type.Namespace}");
            Console.WriteLine($"FillName : {_type.FullName}");
            Console.WriteLine();
        }

        private void GetListConstructors()
        {
            Console.WriteLine("List constructors : ");
            var listConstructors = _type.GetConstructors();
            if (listConstructors.Length != 0)
            {
                foreach (var item in listConstructors)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No found");
            }
            Console.WriteLine();
        }

        private void GetListProperties()
        {
            Console.WriteLine("List properties :");
            var lisrProperties = _type.GetProperties();
            if (lisrProperties.Length != 0)
            {
                foreach (var item in lisrProperties)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No found");
            }
            Console.WriteLine();
        }

        private void GetListMethods()
        {
            Console.WriteLine("List methods");
            var listMethods = _type.GetMethods();
            string modificator = "";
            if (listMethods.Length != 0)
            {
                foreach (var item in listMethods)
                {
                    if (item.IsPublic)
                        modificator = "public ";
                    else if (item.IsPrivate)
                        modificator = "private ";
                    else if (item.IsAssembly)
                        modificator = "internal ";
                    else if (item.IsFamily)
                        modificator = "protected ";
                    else if (item.IsFamilyAndAssembly)
                        modificator = "private protected ";
                    else if (item.IsFamilyOrAssembly)
                        modificator = "protected internal ";
                    if (item.IsStatic)
                        modificator = "static";
                    Console.WriteLine($"{modificator} {item}");
                }
            }
            else
            {
                Console.WriteLine("No found");
            }
            Console.WriteLine();
        }

        private void GetListInterfaces()
        {
            Console.WriteLine("List interfaces : ");
            var listInterfaces = _type.GetInterfaces();
            if (listInterfaces.Length != 0)
            {
                foreach (var item in listInterfaces)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No found");
            }
            Console.WriteLine();
        }

        private void GetListFields()
        {
            Console.WriteLine("List fields : ");
            var listFields = _type.GetFields();
            if (listFields.Length != 0)
            {
                foreach (var item in listFields)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No fouhd");
            }
            Console.WriteLine();
        }

        private void GetListEvents()
        {
            Console.WriteLine("List events : ");
            var listEvents = _type.GetEvents();
            if (listEvents.Length != 0)
            {
                foreach (var item in listEvents)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No found");
            }
            Console.WriteLine();
        }

        private readonly Type _type;
    }
}


