# BeautySaloon

В Данном репозитории представленна проведенная работа по разработки внутреннего приложиния для салона красоты. Приложение на данныый момент находится на стадии разработки, всвязи с этим есть некоторые недочеты.

![image](https://github.com/KoshelevaOlga/BeautifulSalon/assets/126570872/6fa6a453-1f0f-4b70-bc02-c1f5394bfece)
ERD

https://www.figma.com/file/wFuZmQVTSqMBr9FXlP7bZM/%D0%A1%D0%B0%D0%BB%D0%BE%D0%BD-%D0%BA%D1%80%D0%B0%D1%81%D0%BE%D1%82%D1%8B?type=design&node-id=2%3A2&mode=dev
Ссылка на дизайн


# Демонстрация работы приложения
Для начала небольшое описание: 
Данное приложение является внутренним и предусматривает вход только для двух видов пользователей: 
  1. Администраторы - Пользователи у которых больше прав
  2. Операторы - имеют права только для создания записи клиента на услугу

# Вход под админом
Окно входа у всех пользователей одинаковое и регистрация не предусмотренна, как было написано ранее приложение является внутреним.

![Авторизация](https://github.com/KoshelevaOlga/BeautySaloon/assets/126570872/bee9a957-7ac9-4d56-b331-6618c6e4e70d)

Первое окно которое встречает Администратора после авторизации это список всех предоставляемых услуг в данном салоне. В верхнем правом углу мы видим две кнопки, которыеее соотвтственно нужны для редактирования и удаления уже существующих услуг. На данный момент кнопка редактирования работает не стабильно и выдает ошибку, так что мы ее пропустим. В нижней части экрана, под списком услуг мы видим четыре кнопки, давайте рассмотрим функционал каждой из них.
![Список услуг](https://github.com/KoshelevaOlga/BeautySaloon/assets/126570872/5475e62b-2b30-44b6-b7f4-d3ccf031ce43)

Кнопка "Новая услуга"
Здесь мы видим необходимые поля, которые обязательно нужно заполнить для сохранения услуги. В поле Категория присутствует выпадающий список, для более удобного поиска. В самом низу мы видим две кнопки: Сохранить и Вытйи(В данном случае вернуться на предыдущую странницу)
![Создание услуги](https://github.com/KoshelevaOlga/BeautySaloon/assets/126570872/e2bc589b-43f1-4b8e-916d-ae4d5dc05cc1)

Далее кнопка которую мы видим на окне со списком услуг "Работники"
Данная кнопкак переносит нас на страницу со списком работников. Здесь мы можем удалить из базы уже существующего работникаа, добавить нового работника или выполнить переход по страницам.
![Список работников](https://github.com/KoshelevaOlga/BeautySaloon/assets/126570872/a07c0e3a-b4fc-4587-87db-9afbbd2a95ab)

Рассмотрим работу кнопки "Новый работник"
Она переносит нас в окно создания пользователя/сотрудника. Так же здесь естьмаленькая кнопка в виде знака + (который сьехал) нажав на которую мы увидим новое окно
![Добавление пользователя](https://github.com/KoshelevaOlga/BeautySaloon/assets/126570872/27150621-5053-4147-8499-f8bc6efaa562)

кнопка +
Данная кнопка позволяет создать новую должность, если ее еще не существует в базе.
![Создание новой должности](https://github.com/KoshelevaOlga/BeautySaloon/assets/126570872/a9eccfe9-4b4f-4895-9c62-abb2d2b43b43)

Вернемся к первому окну со списком услуг. Осталась одна кнопка про которую мы не поговорили, "Записи"
Она переносит нас в окно гле мы можем ознакомиться со всеми клиентами и услугами которые были им предоставленны в нашем салоне.
![История записей](https://github.com/KoshelevaOlga/BeautySaloon/assets/126570872/759a8ae2-ad92-4fe7-bfe1-5b6e8441d1fa)

кнопкаа "Новая запись"
Позволяет создать новую запись клиента на услугу 
![Запись на услугу](https://github.com/KoshelevaOlga/BeautySaloon/assets/126570872/58f65373-a851-4346-9885-66793a5b31dc)

Кнопка выход которая находиться на трех окнах: Список услуг, Список сотрудников, Список всех предоставленных услуг, Возвращает нас в окно авторизации

# Вход под оператором
Окно регистрации, как было описано ранее, точно такоеже 

![Вход под Оператором](https://github.com/KoshelevaOlga/BeautySaloon/assets/126570872/226bb1a0-31a1-440f-b0f9-3dbacf7bf996)

Первое окно которое нас встречает при входе под данной ролью так же, как у админа. Но как мы можем заметить, тут гораздо меньше функционал. Первая кнопка которую мы видим "История записей"
![Список услуг](https://github.com/KoshelevaOlga/BeautySaloon/assets/126570872/71c685c4-8069-4a2a-91a4-98acefe50d89)

Данная кнопка переносит нас на окно в котором предоставлен списов всех предоставленных услуг
![История записей](https://github.com/KoshelevaOlga/BeautySaloon/assets/126570872/142c267c-3c81-4994-9f7d-212e2f006984)

Кнопка "Новая запись"
Данная кнопка которая находиться на двух описанных выше окнах работает ждентично. Она открывает окно создания записи клиента на услугу
![Новая запись на услугу](https://github.com/KoshelevaOlga/BeautySaloon/assets/126570872/aacb31a6-3f75-4d7a-8d37-5bcfa96bb736)

Так же на окнах с списком всех предосталенных услуг и списком всех услуг, которые предоставляются салоном, есть кнопка выхода, которая переносит нас в окно авторизации

# Заключение
На данный момент есть много несоответствий с созданным ранее и предоставленным по ссылке выше дизайном. Так же еще реализован не весь функционал. Но я не стою на месте и продолжу работу над данным проектом, и надеюсь, что в скором времени все будет идеаль.
Спасибо за внимание!

P.S. Реализация данного проекта выполнена примерно за сутки (без учета Перерывов). Текст к данному редми писался в 12 ночи (я очень сильно хочу спать) так что прошу не судить мою работу очень строго
