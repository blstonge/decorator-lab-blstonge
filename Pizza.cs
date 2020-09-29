namespace decorater_lab_blstonge
{
    public abstract class Pizza
    {
        public string Size{get; set;}
        public string Description{get; set;}

        public Pizza()
        {
            Description = "Unknown Pizza";
        }

        public virtual string GetDescription()
        {
            return Size + " " + Description;
        }

        public virtual string GetSize()
        {
            return Size;
        }
        public virtual void SetSize(string size)
        {
            Size = size;
        }
        public abstract double Cost();
    }
}