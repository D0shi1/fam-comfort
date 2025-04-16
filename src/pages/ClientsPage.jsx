import React, { useState } from "react";

export function Clients() {
  const [activeCategory, setActiveCategory] = useState("Каталоги");

  const documents = {
    Каталоги: [
      {
        name: "Каталог продукции 2025",
        description: "Полный каталог текущих продуктов и услуг.",
        link: "/documents/catalog_2025.pdf",
      },
    ],
    Сотрудничество: [
      {
        name: "Бланк претензии ОМЦ-ПРОФИЛЬ",
        description:
          "Стандартная форма заявки при выявлении брака продукции ООО 'ОМЦ-ПРОФИЛЬ'. Языки: RU, ENG.",
        link: "/documents/claim_form.pdf",
      },
      {
        name: "Сертификат ЗОВ-ПРОФИЛЬ",
        description:
          "Сертификат соответствия требованиям СТБ 1871-2008, ГОСТ 16371-93.",
        link: "/documents/zov_profile_certificate.pdf",
      },
      {
        name: "Сертификат ЗОВ-ТПС",
        description:
          "Сертификат соответствия требованиям СТБ 1871-2008, ГОСТ 16371-93.",
        link: "/documents/zov_tps_certificate.pdf",
      },
    ],
    "Схемы сборки": [
      {
        name: "Схема сборки шкафа",
        description: "Подробная инструкция по сборке.",
        link: "/documents/assembly_manual.pdf",
      },
    ],
    "3D": [
      {
        name: "3D модель мебели",
        description: "Пример визуализации мебели в формате 3D.",
        link: "/documents/furniture_3d_model.obj",
      },
    ],
    "Прочие документы": [
      {
        name: "Гарантийный талон",
        description: "Документ с гарантийными обязательствами.",
        link: "/documents/warranty_card.pdf",
      },
    ],
  };

  return (
    <div className="bg-gray-100 min-h-screen flex flex-col items-center">
      <header className="py-6 w-full">
        <h1 className="text-4xl font-bold text-center mb-6 text-black">
          Клиентам
        </h1>
      </header>
      <main className="container mx-auto px-6 py-10 bg-white rounded-lg shadow-lg">
        <section className="mb-10">
          <p className="text-lg text-gray-700 leading-relaxed">
            Мы рады предоставить своим клиентам всю необходимую информацию по
            нашей продукции. В разделах «Каталоги» и «Презентации» Вы найдете
            актуальные материалы по мебельным фасадам и погонажному профилю.
            Памятки и информацию о скидках содержит раздел «Информация». Для
            изучения типовых договоров и схем сборки мебели посетите раздел
            «Документы». Дизайнерам и проектировщикам предлагаем скачать
            прорисованные в программах 3ds Max и PRO100 элементы мебели и
            стеновых панелей в подразделе «Библиотека для 3D-проектирования».{" "}
            <br />
            Мы всегда стремимся к взаимовыгодному сотрудничеству с новыми
            оптовыми и розничными клиентами, а также индивидуальными
            предпринимателями. Воспользуйтесь разделами «Информация» и
            «Презентации», чтобы узнать об условиях сотрудничества, географии
            поставок и ценовой программе.
          </p>
        </section>

        <section className="mb-6">
          <h2 className="text-2xl font-bold text-gray-800 mb-4">Категории</h2>
          <div className="flex flex-wrap gap-4">
            {Object.keys(documents).map((category) => (
              <button
                key={category}
                className={`relative w-48 h-14 bg-black text-white rounded-lg cursor-pointer overflow-hidden group transition-all duration-300 ${
                  activeCategory === category
                    ? "border-2 border-yellow-600"
                    : ""
                }`}
                onClick={() => setActiveCategory(category)}
              >
                <span className="absolute inset-0 bg-yellow-600 opacity-0 group-hover:opacity-100 transition-opacity rounded-lg"></span>
                <span className="relative z-10">{category}</span>
              </button>
            ))}
          </div>
        </section>

        <section>
          <h2 className="text-2xl font-bold text-gray-800 mb-4">
            {activeCategory}
          </h2>
          <ul>
            {documents[activeCategory].map((doc, index) => (
              <li key={index} className="mb-6">
                <h3 className="text-lg font-bold">{doc.name}</h3>
                <p className="text-gray-700">{doc.description}</p>
                <a href={doc.link} download className="text-blue-500 underline">
                  Скачать
                </a>
              </li>
            ))}
          </ul>
        </section>
      </main>
    </div>
  );
}
