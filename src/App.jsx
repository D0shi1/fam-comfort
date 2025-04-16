import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { Layout } from "./Layout";
import { HomePage } from "./pages/HomePage";
import { AboutPage } from "./pages/AboutPage";
import { Contacts } from "./pages/ContactsPage";
import { Clients } from "./pages/ClientsPage";
import { Catalog } from "./pages/CatalogPage";
import { Facades } from "./pages/FacadesPage";
import { Decor } from "./pages/DecorPage";

export default function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route index element={<HomePage />} />
          <Route path="about" element={<AboutPage />} />
          <Route path="contacts" element={<Contacts />} />
          <Route path="clients" element={<Clients />} />
          <Route path="catalog" element={<Catalog />} />
          <Route path="catalog/facades" element={<Facades />} />
          <Route path="catalog/decor" element={<Decor />} />
        </Route>
      </Routes>
    </Router>
  );
}
