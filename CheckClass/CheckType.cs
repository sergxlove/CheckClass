
using System.Reflection;
using System.Text;
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

        public string GetInfoTypeString()
        {
            StringBuilder result = new StringBuilder();
            return result.ToString();
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
            Console.WriteLine($"FullName : {_type.FullName}");
            Console.WriteLine();
        }

        private string GetStatsTypeString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Name : {_type.Name} \nNamespace : {_type.Namespace} \nFullName : {_type.FullName}\n\n");
            return result.ToString();
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

        private string GetListConstructorsString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("List constructors : \n");
            var listConstructors = _type.GetConstructors();
            if (listConstructors.Length != 0)
            {
                foreach (var item in listConstructors)
                {
                    result.Append($"{item} \n");
                }
            }
            else
            {
                result.Append("No found\n");
            }
            result.Append('\n');
            return result.ToString();

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

        private string GetListPropertiesString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("List properties :");
            var listPropeerties = _type.GetProperties();
            if (listPropeerties.Length != 0) 
            {
                foreach (var item in listPropeerties)
                {
                    result.Append($"{item} \n");
                }
            }
            else
            {
                result.Append("No found\n");
            }
            result.Append('\n');
            return result.ToString();
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

        private string GetListMethodsString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("List methods :\n");
            string modificator = "";
            var listMethods = _type.GetMethods();
            if (listMethods.Length != 0)
            {
                foreach(var item in listMethods)
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
                    result.Append($"{modificator} {item} \n");
                }
            }
            else
            {
                result.Append("No found \n");
            }
            result.Append('\n');
            return result.ToString();

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

        private string GetListInterfacesString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("List interfaces :\n");
            var listInterfaces = _type.GetInterfaces();
            if(listInterfaces.Length != 0)
            {
                foreach(var item in listInterfaces)
                {
                    result.Append($"{item} \n");
                }
            }
            else
            {
                result.Append('\n');
            }
            result.Append('\n');
            return result.ToString();
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

        private string GetListFieldsString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("List field \n");
            var listFields = _type.GetFields();
            if(listFields.Length != 0)
            {
                foreach( var item in listFields)
                {
                    result.Append($"{item} \n");
                }
            }
            else
            {
                result.Append("No found \n");
            }
            result.Append('\n');
            return result.ToString();
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

        private string GetListEventsString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("List events \n");
            var listEvents = _type.GetEvents();
            if (listEvents.Length != 0)
            {
                foreach (var item in listEvents)
                {
                    result.Append($"{item} \n");
                }
            }
            else
            {
                result.Append("No found \n");
            }
            result.Append('\n');
            return result.ToString();
        }

        private readonly Type _type;
    }
}


