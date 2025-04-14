import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { Layout } from "./Layout";
import { HomePage } from "./pages/HomePage";
import { AboutPage } from "./pages/AboutPage";
// Временно закомментируйте если нет этих страниц
// import { CatalogPage } from "./pages/CatalogPage";
// import { AboutPage } from "./pages/AboutPage";

export default function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route index element={<HomePage />} />
          <Route path="/about" element={<AboutPage />} />
          {/* <Route path="catalog" element={<CatalogPage />} /> */}
          {/* <Route path="about" element={<AboutPage />} /> */}
        </Route>
      </Routes>
    </Router>
  );
}