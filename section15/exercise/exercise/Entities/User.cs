namespace exercise.Entities
{
    public abstract class User
    {
        public int Id { get; private set; }

        protected User(int id)
        {
            this.Id = id;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is User))
            {
                throw new System.ArgumentException("The argument is not an User type!");
            } 
            else
            {
                return this.Id.Equals(((User)obj).Id);
            }
        }
    }
}