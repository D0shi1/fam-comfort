import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";

export function Catalog() {
  const navigate = useNavigate();
  const [catalogs, setCatalogs] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchCatalogs = async () => {
      try {
        const response = await axios.get(
          "http://localhost:5251/api/v1/catalog"
        );
        const fetchedCatalogs = response.data.map((catalog) => ({
          id: catalog.id,
          name: catalog.name.toLowerCase(),
          pathToImage: "src/img/furniture.jpg",
        }));
        setCatalogs(fetchedCatalogs);
      } catch (error) {
        console.error("Ошибка при загрузке каталогов:", error);
      } finally {
        setLoading(false);
      }
    };

    fetchCatalogs();
  }, []);

  if (loading) {
    return (
      <div className="flex justify-center items-center min-h-screen">
        <p className="text-lg font-semibold text-gray-800">
          Загрузка каталогов...
        </p>
      </div>
    );
  }

  return (
    <div className="bg-gray-100 min-h-screen flex flex-col items-center">
      <header className="py-6 w-full">
        <h1 className="text-4xl font-bold text-center mb-6 text-black">
          Каталог
        </h1>
      </header>
      <main className="container mx-auto px-6 py-10">
        <section className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8">
          {catalogs.map((catalog) => (
            <div
              key={catalog.id}
              className="relative group overflow-hidden rounded-lg shadow-lg cursor-pointer"
              onClick={() =>
                navigate(`/catalog/facades`, { state: { name: catalog.name } })
              }
            >
              <div className="absolute top-0 left-0 w-full bg-white text-black py-2 text-center text-xl font-bold">
                {catalog.name}
              </div>
              <img
                src={catalog.pathToImage}
                alt={catalog.name}
                className="w-full h-full object-cover transition-transform duration-500 group-hover:scale-105"
              />
            </div>
          ))}
        </section>
      </main>
    </div>
  );
}

export default Catalog;
