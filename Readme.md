SELECT p.Name, c.Name
FROM Products pr
LEFT JOIN ProductsCategories prc
	ON pr.Id = prc.ProductId
LEFT JOIN Categories cat
	ON prc.CategoryId = cat.Id;
ORDER BY pr.Name;
