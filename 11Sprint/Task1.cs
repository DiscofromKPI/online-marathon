class ReflectFields
    {
        public static int MeasureX;
        public static int MeasureY;
        public static int MeasureZ;
        public static string Name;
        public static void OutputFields()
        {
            foreach (var property in typeof(ReflectFields).GetFields())
            {
                var type = property.FieldType.Name == "String" ? "string" : "int";
                Console.WriteLine($"{property.Name} ({type}) = {property.GetValue(null)}");
            }

        }
    }
