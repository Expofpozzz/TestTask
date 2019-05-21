create table dbo.products(
  id number not null,
  name varchar2(255) null,

  constraint pk_products_id primary key(id)
);

create table dbo.categories(
  id number not null,
  name varchar2(255) null,

  constraint pk_categories_id primary key(id)
);

create table dbo.products_map(
  product_id number not null,
  category_id number null,

  constraint fk_products_map_product_id foreign key (product_id) references dbo.products(id),
  constraint fk_products_map_category_id foreign key (category_id) references dbo.categories(id)
);

insert into dbo.categories (id, name) values (1,'Химия');
insert into dbo.categories (id, name) values (2,'Одежда');
insert into dbo.categories (id, name) values (3,'Продукты');

insert into dbo.products (id, name) values (1,'Порошок');
insert into dbo.products (id, name) values (2,'Шапунь');
insert into dbo.products (id, name) values (3,'Зубная паста');
insert into dbo.products (id, name) values (4,'Блузка');
insert into dbo.products (id, name) values (5,'Рубашка');
insert into dbo.products (id, name) values (6,'Джинсы');
insert into dbo.products (id, name) values (7,'Пиво');
insert into dbo.products (id, name) values (8,'Рыба');
insert into dbo.products (id, name) values (9,'Хлеб');
insert into dbo.products (id, name) values (10,'Вертолёт');
insert into dbo.products (id, name) values (11,'Самолёт');
insert into dbo.products (id, name) values (12,'Параплан');

insert into dbo.products_map(product_id, category_id) values (1,1);
insert into dbo.products_map(product_id, category_id) values (2,1);
insert into dbo.products_map(product_id, category_id) values (3,1);
insert into dbo.products_map(product_id, category_id) values (4,2);
insert into dbo.products_map(product_id, category_id) values (5,2);
insert into dbo.products_map(product_id, category_id) values (6,2);
insert into dbo.products_map(product_id, category_id) values (7,3);
insert into dbo.products_map(product_id, category_id) values (8,3);
insert into dbo.products_map(product_id, category_id) values (9,3);
insert into dbo.products_map(product_id, category_id) values (10,2);
insert into dbo.products_map(product_id, category_id) values (10,3);
insert into dbo.products_map(product_id, category_id) values (11,null);
insert into dbo.products_map(product_id, category_id) values (11,null);
insert into dbo.products_map(product_id, category_id) values (11,null);

select p.name || ' - ' || c.name as result
from dbo.products p
left join dbo.products_map on p.id = products_map.product_id
left join dbo.categories c on products_map.category_id = c.id