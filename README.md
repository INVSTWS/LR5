# LR5

Завдання на розробку програм 

**Завдання 1 :**

Використовуючи принцип успадкування розробити програму, яка надає користувачеві функціональність калькулятора, що має два режими роботи: «стандартний» і «інженерний». 
4 
У «стандартному» режимі калькулятор може виконувати будь-яку з чотирьох арифметичних операцій: «+», «-», «*», «/» з двома дійсними числами. У «інженерному» режимі крім арифметичних операцій він також може виконувати додаткову операцію, яка визначається варіантом завдання (див. табл. нижче). Поточний режим роботи програми вибирає користувач програми. 
Програма повинна забезпечувати: 
1. Створення по одному об'єкту класів 1 і 2. 
2. Одноразове введення вихідних даних, отримання результату обчислень у вибраному режимі роботи, виведення його на екран (рівень 1). 
3. Багаторазове повторення процесу введення початкових даних, отримання результату обчислень у вибраному режимі роботи і виведення його на екран поки користувач не введе певний рядок символів (рівні 2 - 4). 
4. Виконання обробки наступних помилкових ситуацій: «поділ на нуль», «вихідні дані для виконання додаткової операції не відповідають обмеженням варіанта завдання» (рівень 4). 
Функціональність програми має бути реалізована в трьох класах: Клас 1, Клас 2, Клас 3, які повинні знаходитися в різних файлах проекту. 
Клас 1 є базовим і призначений для опису обчислювального модуля «стандартного» режиму. Поля даного класу повинні відповідати початковим даним для виконання арифметичних операцій. Для встановлення значень полів і отримання їх поточних значень має використовуватися відповідні властивості (C#) або методи set ... і get ... (Java). Цей клас має конструктор без параметрів. Виконання кожної з арифметичних операцій повинно виконуватися за допомогою відповідного нестатичного методу цього класу. 
Клас 2 є спадкоємцем Класу 1 і призначений для опису обчислювального модуля «інженерного» режиму. Цей клас при необхідності повинен містити одне або кілька полів (для встановлення значень полів і отримання їх поточних значень повинні використовуватися відповідні властивості (C#) або методи set ... і get ... (Java)). В цьому класі повинен бути конструктор без параметрів. Додаткова операція «інженерного калькулятора» має бути реалізована у вигляді нестатичного методу даного класу. 

Клас 3 - містить головний метод програми. 
Рекомендована структура класів програми (метод Pow() призначений для обчислення функції ab; # - protected) наведена на рис. 1. 

Завданя 2 
Перетворити програму з завдання 1 таким чином, щоб в ній використовувалися абстрактний клас і інтерфейс. Нова програма повинна працювати також, як програма з завдання 1 по відповідному варіанту. 
Функціональність програми має бути реалізована в одному абстрактному класі, одному інтерфейсі і трьох звичайних класах.

Абстрактний клас AbstractCalc має поле - модель калькулятора і метод для отримання поточного значення цього поля, а також абстрактні методи для опису операцій обчислювального модуля «стандартного» режиму, тобто арифметичних операцій. Клас OrdinaryCalc обчислювального модуля «стандартного» режиму є спадкоємцем абстрактного класу AbstractCalc і перевизначає його методи. В іншому його сенс той же, що і в завданні 1. Методи обчислювального модуля «стандартного» режиму повинні викликатися поліморфним чином, тобто через посилання на базовий клас AbstractCalc. 
Інтерфейс IAdvanced призначений для опису додаткової операції обчислювального модуля «інженерного» режиму. Клас AdvancedCalc 

обчислювального модуля «інженерного» режиму є спадкоємцем класу обчислювального модуля «стандартного» режиму і реалізує інтерфейс IAdvanced. Додаткова операція обчислювального модуля «інженерного» режиму повинна викликатися поліморфним чином, тобто через посилання на інтерфейс IAdvanced. 
У застосунку також є клас MainClass, в якому знаходиться головний метод. 

