
class Marketing extends Person {
    private String id;

    public String getId() {
        return id;
    }

    public String toString() {
        return getId();
    }
}

class Person {
    private String name;

    public String getName() {
        return name;
    }
}

public class Main {
    public static void main(String[] args) {
        System.out.println(new Margetting().getName());
    }
}