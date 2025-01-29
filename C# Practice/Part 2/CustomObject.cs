namespace Assignment29
{
    public class CustomObject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public CustomObject(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public override string ToString()
        {
            return $"Object [ID: {ID}, Name: {Name}].";
        }

        // public override bool Equals(object obj)
        // {
        //     CustomObject customObject = obj as CustomObject;

        //     return customObject.ID == ID && customObject.Name == Name;
        // }

        public static bool operator ==(CustomObject customObject1, CustomObject customObject2)
        {
            return customObject1.ID.Equals(customObject2.ID) && customObject1.Name.Equals(customObject2.Name);
        }

        public static bool operator !=(CustomObject customObject1, CustomObject customObject2)
        {
            return !(customObject1.ID.Equals(customObject2.ID) && customObject1.Name.Equals(customObject2.Name));
        }
    }
}