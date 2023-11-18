
# EN   
Create a game. Time limit is 12 hours. Place on git, commit once an hour.

   Unity version 2022.3.*
   platform - Android
   screen orientation - portrait

Gameplay:  
    The player controls the movement of the hero, the hero moves to where the player tap.  
    On the playing field there are enemies and goodies.  
    The player can pick up the goodies, earning points.  
    Encountering an enemy loses a life.  
    The game ends when the last life is lost.  
    The goodies are static, enemies can move (each has their own AI that sets their movement goal).  
User Interface:  
    Start window with Play button.  
    Display lives and points during the game.  
    End-of-game window with a list of records and highlighting the current score if it hits the  
    in the record 50. Records are stored on disk.  
Checklist:  
    Architecture:  
        -Game logic is decoupled from the view (e.g. like the MVVM pattern), this applies to UIs  
         and game objects. Simply put, the game model does not use UnityEngine.  
        -Banned: ECS, Zenject and their analogs. (Zenject was allowed)  
    Unity:  
        -animation (controller, logic of transitions between states)  
        -raycasting  
        -collider (add any Collider message)  
        -coroutine  
        -UI scroll  
        -UI mask  
        -materials: creation and modification in rantime  
    C#:  
        - singleton  
        - enum  
        - switch  
        - file handling  
        - threads  
        - json ((de)serialization)  
        - object pool  
        - event called in the Set field method  
        - generic class or method  

# RU  

Создать игру. Лимит времени - 12 часов. Разместить на гите, коммитить раз в час.

   Версия Юнити 2022.3.*
   платформа - Андроид
   ориентация экрана - портретная

Геймплей:  
    Игрок управляет движением героя, герой перемещается туда, где тапнул игрок.  
    На игровом поле есть враги и ништяки.  
    Игрок может подбирать ништяки, зарабатывая очки.  
    Столкновение с врагом - теряет жизнь.  
    Игра заканчивается, когда потеряна последняя жизнь.  
    Ништяки статичны, враги могут двигаться (у каждого свой AI, задающий им цель перемещения).  
Пользовательский интерфейс:  
    Стартовое окно с кнопкой Плэй.  
    Во время игры отображать жизни и очки.  
    Окно окончания игры со списком рекордов и подсветкой текущего результата, если он попал
    в рекордные 50. Рекорды хранятся на диске.  
Чек-лист:  
    Архитектура:  
        -Игровая логика отделена от вью (например, как MVVM паттерн), это касается UI
         и игровых объектов. Проще говоря, модель игры не ипользует UnityEngine.  
        -Запрещены: ECS, Zenject и их аналоги. (Zenject разрешили)  
    Юнити:  
        -анимация (контроллер, логика переходов между состояниями)  
        -raycasting  
        -коллайдер (добавить любой Collider message)  
        -корутина  
        -UI скролл  
        -UI маска  
        -материалы: создание и модификация в рантайме  
    C#:
        - синглтон  
        - перечисление (enum)  
        - switch  
        - работа с файлами  
        - потоки (threads)  
        - json ((де)сериализация)  
        - пул объектов  
        - событие, вызываемое в методе Set поля  
        - универсальный класс или метод (generic)  
