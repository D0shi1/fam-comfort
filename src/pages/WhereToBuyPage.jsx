import React from "react";

export const WhereToBuyPage = () => {
  const locations = [
    { id: 1, name: "Магазин 1", address: "ул. Примерная, 1" },
    { id: 2, name: "Магазин 2", address: "ул. Примерная, 2" },
    { id: 3, name: "Магазин 3", address: "ул. Примерная, 3" },
  ];

  return (
    <div className="bg-gray-100 min-h-screen flex flex-col items-center">
      <header className="py-6 w-full">
        <h1 className="text-4xl font-bold text-center mb-6 text-black">
          Где купить
        </h1>
      </header>
      <main className="container mx-auto px-6 py-10">
        <ul className="space-y-4">
          {locations.map((location) => (
            <li
              key={location.id}
              className="bg-white p-4 shadow rounded-lg border border-gray-300"
            >
              <h2 className="text-xl font-semibold text-gray-800">
                {location.name}
              </h2>
              <p className="text-gray-600">{location.address}</p>
            </li>
          ))}
        </ul>
      </main>
    </div>
  );
};

export default WhereToBuyPage;
