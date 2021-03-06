class Mammal {

    public void eat () {System.out.println("I am Eating");};

}
interface IWalkable {

        public void walk();

}
// Implement Interface directly > NO dependency injection
class Dog extends Mammal implements IWalkable{

   Walkable walker;

   public Dog(Walkable walker)
   {
       this.walker = walker;
   }

   public void setWalker (Walkable w) {   
        this.walker=w; 
   }
    // method implemented
   public void walk () {System.out.println("I am Walking");};

}
class Cat extends Mammal implements IWalkable
{
    public Cat()
    {

    }

    public void walk () {System.out.println("I am Walking");};
}
public class TestMammal {
    public static void main(String args[]) {

        System.out.println("Composition over Inheritance");;

        System.out.println("\nDog");

        Walkable walker = new Walkable();

        Dog fido = new Dog();
        fido.setWalker(walker);
        fido.eat();
        fido.walker.walk();

        Dog anotherDog = new Dog(walker)
        fido.walker.walk();
    }
}
