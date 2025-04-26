import React, { useState, useEffect } from "react";
import { useLocation } from "react-router-dom";
import axios from "axios";
import ProductList from "../components/Catalog/ProductList"; 

export function Facades() {
  const location = useLocation();
  const catalogName = location.state?.name || "facades";
  const [products, setProducts] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchData = async () => {
      setLoading(true);
      try {
        const response = await axios.get(`http://localhost:5251/api/v1/categories/${catalogName}`);
        const fetchedProducts = response.data.map(category => ({
          id: category.categoryId,
          name: category.name,
          imageUrl: category.pathToImage,
        }));
        setProducts(fetchedProducts);
      } catch (error) {
        console.error("Ошибка при загрузке данных:", error);
      } finally {
        setLoading(false);
      }
    };

    fetchData();
  }, [catalogName]);

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
        <h1 className="text-4xl font-bold text-center mb-6 text-black">{catalogName}</h1>
      </header>
      <main className="container mx-auto px-6 py-10">
        {products.length > 0 ? (
          <ProductList products={products} />
        ) : (
          <p className="text-gray-700 text-center">Нет доступных {catalogName}.</p>
        )}
      </main>
    </div>
  );
}

export default Facades;
