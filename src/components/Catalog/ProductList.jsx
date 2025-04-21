import React from "react";
import ProductCard from "./ProductCard";

const ProductList = ({ products }) => {
  return (
    <div className="grid grid-cols-4 gap-6">
      {products.map((product) => (
        <ProductCard
          key={product.id}
          name={product.name}
          imageUrl={product.imageUrl}
        />
      ))}
    </div>
  );
};

export default ProductList;
