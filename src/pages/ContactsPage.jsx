import React from "react";

export function Contacts() {
  return (
    <div className="bg-white min-h-screen flex flex-col items-center">
      <header className="py-6 w-full">
        <h1 className="text-4xl font-bold text-center mb-4 pb-10 text-black">
          Контакты
        </h1>
      </header>
      <main className="container mx-auto px-6 py-10">
        <section className="bg-white rounded-lg shadow-lg p-6 mb-10 border border-gray-200">
          <h2 className="text-2xl font-bold text-gray-800 mb-4">Маркетинг</h2>
          <p className="text-lg text-gray-700">
            <strong>E-mail:</strong>{" "}
            <a href="mailto:marketing@omcprofil.by" className="text-green-500">
              marketing@omcprofil.by
            </a>
          </p>
          <p className="text-lg text-gray-700">
            <strong>Тел./факс:</strong> +375 (152) 60-81-63
          </p>
          <p className="text-lg text-gray-700">
            <strong>Телефон:</strong> +375 (29) 103-33-04
          </p>
        </section>

        <section className="bg-white rounded-lg shadow-lg p-6 mb-10 border border-gray-200">
          <h2 className="text-2xl font-bold text-gray-800 mb-4">
            Отдел продаж
          </h2>
          <p className="text-lg text-gray-700">
            <strong>E-mail:</strong>{" "}
            <a href="mailto:sales@omcprofil.by" className="text-green-500">
              sales@omcprofil.by
            </a>
          </p>
          <p className="text-lg text-gray-700">
            <strong>Тел./факс:</strong> +375 (152) 60-81-63
          </p>
          <div className="mt-6">
            <h3 className="text-xl font-bold text-gray-800">
              Михаил Кондрашов
            </h3>
            <p className="text-lg text-gray-700">Начальник службы сбыта</p>
            <p className="text-lg text-gray-700">
              <strong>Моб.:</strong> +375 (29) 111-94-94
            </p>
          </div>
          <div className="mt-6">
            <h3 className="text-xl font-bold text-gray-800">
              Павел Миклашевич
            </h3>
            <p className="text-lg text-gray-700">
              Специалист по продаже (PL, EN)
            </p>
            <p className="text-lg text-gray-700">
              <strong>Моб.:</strong> +375 (29) 103-33-23
            </p>
            <p className="text-lg text-gray-700">
              Работает с клиентами РБ, РФ и Польши. Основные направления:
              мебельный и строительный погонаж.
            </p>
          </div>
        </section>
      </main>
    </div>
  );
}
