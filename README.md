# Unity. Модуль 3. Вебинар 13

Этот репозиторий содержит задание для вебинара 13

# Задание: Ульта!

## Описание

Добавим нашему персонажу возможность раз в определенное время использовать супер ультимативную способность. Очень мощное заклинание с перезарядкой, которое превращает всех врагов на карте в резиновых уточек.

<img src="https://github.com/copetonrob/YP_Unity_M3_W13/blob/main/img/task.gif" width="600"/>

## Инструкция

Если у тебя нет наработок по шутеру, загрузи стартовый набор с одного из прошлых вебинаров. Пакет лежит [тут](https://github.com/copetonrob/YP_Unity_M3_W11/blob/main/packages/M3W11.unitypackage)

Главная сцена лежит в папке Assets/M3W11 и называется M3W11_basic

Найди какую-нибудь забавную модельку (в которую будут превращаться враги) или можешь взять [уточку](https://github.com/copetonrob/YP_Unity_M3_W13/blob/main/packages/M3W13_duck.unitypackage), которую мы подготовили

Найди, создай или возьми готовый [Particle System эффект](https://github.com/copetonrob/YP_Unity_M3_W13/blob/main/packages/M3W13_HexEffect.unitypackage), с которым враги будут превращаться.

И еще тебе понадобится иконка заклинания, чтобы видеть, как долго оно будет находится на перезарядке. Можешь найти в интернете или взять [иконку](https://github.com/copetonrob/YP_Unity_M3_W13/blob/main/img/duck_hex_icon.png), которую мы сгенерировали в Mid Jorney

Для начала сделаем иконку, отображающую текущую перезарядку. Создай новый объект в сцене UI -> Image

<img src="https://github.com/copetonrob/YP_Unity_M3_W13/blob/main/img/ui_image.png" width="400"/>

Настрой положение иконки, выстави якорь и задай отступы. Желательно, чтобы иконка была в углу экрана.

<img src="https://github.com/copetonrob/YP_Unity_M3_W13/blob/main/img/image_transform.png" width="400"/>

Назови этот объект IconBackground. Задай в Source Image спрайт иконки и немного затемни картинку параметром Color

<img src="https://github.com/copetonrob/YP_Unity_M3_W13/blob/main/img/image_color.png" width="400"/>

Не забудь, что в настройках иконки, нужно выставить Texture Type -> Sprite(2D and UI)

<img src="https://github.com/copetonrob/YP_Unity_M3_W13/blob/main/img/sprite_settings.png" width="400"/>

Создай в объекте IconBackground дочерний Image

<img src="https://github.com/copetonrob/YP_Unity_M3_W13/blob/main/img/child_image.png" width="400"/>

В него так же добавь спрайт иконки. И выстави Image Type -> Filled. Настрой параметры, это позволит отображать перезарядку заклинания из скрипта

<img src="https://github.com/copetonrob/YP_Unity_M3_W13/blob/main/img/image_filled.png" width="600"/>

Создай скрипт [UltimateHex.cs](https://github.com/copetonrob/YP_Unity_M3_W13/blob/main/scripts/UltimateHex.cs) скопируй содержимое и восстанови утерянные фрагменты кода.

Добавь скрипт на игрока. Навесь все необходимые ссылки

<img src="https://github.com/copetonrob/YP_Unity_M3_W13/blob/main/img/ultimate_refs.png" width="400"/>

Запусти игру и проверь, что все работает!