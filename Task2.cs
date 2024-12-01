// Абстрактний клас для базового калькулятора
abstract class AbstractCalc {
    protected String model;

    public AbstractCalc(String model) {
        this.model = model;
    }

    public String getModel() {
        return model;
    }
//1
    // Абстрактні методи для арифметичних операцій
    public abstract double add(double a, double b);

    public abstract double subtract(double a, double b);

    public abstract double multiply(double a, double b);

    public abstract double divide(double a, double b);
}

// Інтерфейс для додаткових операцій
interface IAdvanced {
    double convertToDegrees(double radians); // Конвертація радіан у градуси
}

// Звичайний калькулятор
class OrdinaryCalc extends AbstractCalc {

    public OrdinaryCalc(String model) {
        super(model);
    }

    @Override
    public double add(double a, double b) {
        return a + b;
    }

    @Override
    public double subtract(double a, double b) {
        return a - b;
    }

    @Override
    public double multiply(double a, double b) {
        return a * b;
    }

    @Override
    public double divide(double a, double b) {
        if (b == 0) {
            throw new ArithmeticException("Ділення на нуль!");
        }
        return a / b;
    }
}

// Інженерний калькулятор
class AdvancedCalc extends OrdinaryCalc implements IAdvanced {

    public AdvancedCalc(String model) {
        super(model);
    }

    @Override
    public double convertToDegrees(double radians) {
        return radians * (180 / Math.PI);
    }
}

// Головний клас
public class MainClass {

    public static void main(String[] args) {
        // Створення екземплярів калькуляторів
        OrdinaryCalc ordinaryCalc = new OrdinaryCalc("StandardCalc v1.0");
        AdvancedCalc advancedCalc = new AdvancedCalc("AdvancedCalc v2.0");

        // Приклад використання
        System.out.println("Модель: " + ordinaryCalc.getModel());
        System.out.println("Додавання: 5 + 3 = " + ordinaryCalc.add(5, 3));

        System.out.println("\nМодель: " + advancedCalc.getModel());
        System.out.println("Конвертація радіан у градуси (π/2): " + advancedCalc.convertToDegrees(Math.PI / 2));
    }
}
