class Mammal {
    public void eat () {System.out.println("I am Eating");};
}

interface IWalkable {
    public void walk();
}

class Walkable implements IWalkable
{
    public void walk() {
        system.println("Look! I'm walking!");
    }
}

// Using dependency injection
class Dog extends Mammal {

   Walkable walker;

   public Dog(Walkable walker)
   {
       this.walker = walker;
   }
   public void setWalker (Walkable w) {   
        this.walker=w; 
   }
}

class Cat extends Mammal
{
    Walker walker;

    public Cat(Walker walker)
    {
        this.walker = walker;
    }
    public void setWalker(Walkable w) {
        this.walker = w;
    }
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

        Cat cat = new Cat(walker)
        cat.walker.walk();
    }
}
