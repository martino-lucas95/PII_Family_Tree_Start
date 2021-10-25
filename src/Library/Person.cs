namespace Library
{
    public class Person: Visitor
    {
        private string name;
        private int age;
 
        public Person(string name, int age){
            this.name = name;
            this.age = age;
        }
        public void Accept(Visitor visitor){
            visitor.Visit(this);
        }
        
    }
}
