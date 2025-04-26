import React from "react";

export function AboutPage() {
  return (
    <div className="min-h-screen bg-gray-50">
      <section className="py-10 bg-white">
        <div className="container mx-auto px-6">
          <h1 className="text-4xl font-bold text-center mb-4 pb-10">
            О компании
          </h1>
          <div className="flex flex-col md:flex-row items-center md:space-x-6">
            <div className="md:w-1/2 text-center md:text-left mb-6 md:mb-0">
              <p className="text-lg mt-2 text-gray-700">
                <h2 className="text-xl font-bold text-red-600">Fam-comfort</h2>
                <p className="mt-2 text-gray-700">
                  <strong>Уютное</strong> дополнение{" "}
                  <strong>современного интерьера</strong>.
                </p>
                <p className="mt-4">
                  Мы взяли <strong>20 лет опыта</strong>, добавили{" "}
                  <strong>современные технологии</strong> и создали бренд,
                  который вам понравится.
                </p>
                ✔️ Все преимущества <strong>проверенного производителя</strong>{" "}
                – без устаревших решений <br />
                ✔️ <strong>Технологии</strong>, которые действительно работают –{" "}
                <strong>5D-окутка</strong>,{" "}
                <strong>трёхслойное покрытие</strong>,{" "}
                <strong>влагостойкие материалы</strong>
                <br />
                ✔️ <strong>Не просто фасады</strong> – а продуманные до мелочей{" "}
                <strong>интерьерные решения</strong>
                <br />
                ✔️ <strong>Гибкость</strong> – быстро адаптируемся под{" "}
                <strong>ваши задачи</strong>
              </p>
            </div>

            <div className="md:w-1/2 flex justify-center md:justify-end">
              <img
                src="src/img/logo.jpg"
                alt="Логотип компании"
                className="w-480 h-auto"
              />
            </div>
          </div>

          <div className="container mx-auto p-6">
            <div className="w-full h-1/4 md:h-[500px] lg:h-[600px]">
              <iframe
                className="w-full h-full rounded-lg shadow-md"
                src="https://www.youtube.com/embed/PofQaXypH4E"
                title="YouTube video player"
                frameBorder="0"
                allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                allowFullScreen
              ></iframe>
            </div>
          </div>
        </div>
      </section>

      <section className="py-16 bg-gray-50">
        <div className="container mx-auto px-6 text-center">
          <h2 className="text-3xl font-bold mb-12">Ассортимент</h2>

          <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-4 gap-6">
            <div>
              <img
                src="/src/img/profil.jpg"
                alt="Профиль погонажный"
                className="w-full h-48 object-cover rounded-lg shadow-md cursor-pointer hover:scale-105 transition-transform duration-300"
              />
              <p className="text-lg font-medium mt-4">Рейки и реечные панели</p>
            </div>

            <div>
              <img
                src="/src/img/facades.jpg"
                alt="Фасады"
                className="w-full h-48 object-cover rounded-lg shadow-md cursor-pointer hover:scale-105 transition-transform duration-300"
              />
              <p className="text-lg font-medium mt-4">Фасады</p>
            </div>

            <div>
              <img
                src="/src/img/decor.jpg"
                alt="Декор"
                className="w-full h-48 object-cover rounded-lg shadow-md cursor-pointer hover:scale-105 transition-transform duration-300"
              />
              <p className="text-lg font-medium mt-4">Перегородки</p>
            </div>

            <div>
              <img
                src="/src/img/furniture.jpg"
                alt="Мебель"
                className="w-full h-48 object-cover rounded-lg shadow-md cursor-pointer hover:scale-105 transition-transform duration-300"
              />
              <p className="text-lg font-medium mt-4">Стеновые панели</p>
            </div>
          </div>
        </div>
      </section>

      <section className="py-16 bg-white">
        <div className="container mx-auto px-6 space-y-12">
          <div className="flex flex-col md:flex-row items-center md:space-x-6">
            <div className="md:w-3/4 text-center md:text-left">
              <h3 className="text-xl font-bold mb-4">Рейки и реечные панели</h3>
              <p className="text-lg text-gray-700">
                Используйте рейки для декорирования мебели и стен. Реечные
                панели - для использования на необработанных поверхностях, а
                также создания акустических зон.
              </p>
            </div>
            <div className="md:w-1/4">
              <img
                src="src/img/profil.jpg"
                alt="Профиль погонажный"
                className="w-full h-64 object-cover rounded-lg shadow-md"
              />
            </div>
          </div>

          <div className="flex flex-col md:flex-row-reverse items-center md:space-x-6">
            <div className="md:w-3/4 text-center md:text-left pl-5">
              <h3 className="text-xl font-bold mb-4">Фасады</h3>
              <p className="text-lg text-gray-700">
                FAM-COMFORT предлагает современные коллекции окрашенных рамочных
                фасадов в инновационной пленке. <br />
                1. Профиль и вставка рамочного фасада производится из МДФ.
                Вставка толщиной 8 мм придает фасаду дополнительную прочность.{" "}
                <br />
                2. 5D окутка рамочного профиля и двустороннее каширование
                вставки. <br />
                3. Эмаль наносится на собранный фасад в 3 этапа. <br />
                4.Защитная пленка поможет избежать царапин при транспортировке и
                установке.
              </p>
            </div>
            <div className="md:w-1/4">
              <img
                src="src/img/facades.jpg"
                alt="Фасады"
                className="w-full h-64 object-cover rounded-lg shadow-md"
              />
            </div>
          </div>

          <div className="flex flex-col md:flex-row items-center md:space-x-6">
            <div className="md:w-3/4 text-center md:text-left">
              <h3 className="text-xl font-bold mb-4">Перегородки</h3>
              <p className="text-lg text-gray-700">
                Благодаря современному и минималистичному дизайну и натуральной
                текстуре они привносят легкость и стильную атмосферу в ваш
                интерьер.
              </p>
            </div>
            <div className="md:w-1/4">
              <img
                src="src/img/decor.jpg"
                alt="Декор"
                className="w-full h-64 object-cover rounded-lg shadow-md "
              />
            </div>
          </div>

          <div className="flex flex-col md:flex-row-reverse items-center md:space-x-6">
            <div className="md:w-3/4 text-center md:text-left pl-5">
              <h3 className="text-xl font-bold mb-4">Стеновые панели</h3>
              <p className="text-lg text-gray-700">
                Стеновые панели просты в монтаже Они позволяют легко подчеркнуть
                индивидуальность вашего пространства с помощью различных форм и
                цветовых решений.
              </p>
            </div>
            <div className="md:w-1/4">
              <img
                src="src/img/furniture.jpg"
                alt="Мебель"
                className="w-full h-64 object-cover rounded-lg shadow-md"
              />
            </div>
          </div>
        </div>
      </section>
    </div>
  );
}
