import React, { useState, useEffect } from "react";
import axios from "axios";
import ProductList from "../components/Catalog/ProductList"; 

export function Facades() {
  const [products, setProducts] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get("http://localhost:5251/api/v1/catalog");
        const fetchedProducts = response.data.flatMap(item => 
          item.categories?.map(category => ({
            id: category.categoryId,
            name: category.name,
            imageUrl: category.pathToImage,
          })) || [] // Безопасное обращение к `categories`
        );
        setProducts(fetchedProducts);
      } catch (error) {
        console.error("Ошибка при загрузке данных:", error);
      } finally {
        setLoading(false);
      }
    };

    fetchData();
  }, []);

  if (loading) {
    return (
      <div className="flex justify-center items-center min-h-screen">
        <p className="text-lg font-semibold text-gray-800">Загрузка...</p>
      </div>
    );
  }

  return (
    <div className="bg-gray-100 min-h-screen flex flex-col items-center">
      <header className="py-6 w-full">
        <h1 className="text-4xl font-bold text-center mb-6 text-black">
          Фасады
        </h1>
      </header>
      <main className="container mx-auto px-6 py-10">
        {products.length > 0 ? (
          <ProductList products={products} />
        ) : (
          <p className="text-gray-700 text-center">Нет доступных фасадов.</p>
        )}
      </main>
    </div>
  );
}

export default Facades;
