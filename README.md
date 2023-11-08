# Lab_4
1. Система моделювання екосистеми.
    - Створіть базовий клас `Живий організм` із характеристиками енергії, віку, розміру.
    - Реалізуйте спадкоємні класи `Тварина`, `Рослина` та `Мікроорганізм`, додавши унікальні характеристики для кожного.
    - Впровадьте інтерфейс `IReproducible`, що визначає можливість розмноження, і `IPredator`, що визначає можливість полювання на інші організми.
    - Реалізуйте клас `Екосистема`, який моделює взаємодію різних організмів між собою: харчування, розмноження, конкуренцію за ресурси.

2. Умовна комп'ютерна мережа (Це не має бути реальна робота з мережею, а імітація, методи для  передачі даних, з'єднання/відключення просто повинні говорити якому компютеру вони передали дані чи до якого компютера під'єднались/відключились).
    - Створіть базовий клас `Комп'ютер` із характеристиками, такими як IP-адреса, потужність, тип ОС.
    - Створіть класи `Сервер`, `Робоча станція` та `Маршрутизатор` як спадкоємницькі від класу `Комп'ютер` з унікальними властивостями для кожного типу.
    - Реалізуйте інтерфейс `IConnectable` (а також додаткові інтерфейси за потреби), який дозволяє з'єднуватися з іншими пристроями у мережі, передавати дані та отримувати їх.
    - Реалізуйте клас `Мережа`, який моделює взаємодію між різними комп'ютерами: передачу даних, з'єднання/відключення.
