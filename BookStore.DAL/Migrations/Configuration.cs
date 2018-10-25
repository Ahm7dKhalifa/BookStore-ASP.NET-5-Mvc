namespace BookStore.DAL.Migrations
{
    using BookStore.DAL.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStore.DAL.EF.BookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookStore.DAL.EF.BookContext context)
        {
            context.Books.AddOrUpdate(new Book { Id = 1, Name = "������� �������", Description = "� 1830 ���� ������ ��������� ������� ������. ������ � ������ ���� ��������� ��-�� ���������, � ��������� ��������� ������ �������� � ����������� �������������� � ������ ������� �������. ���������� ����� ����� � ������� ��� ����� ������������ ���������� ������ ��������. �� ��� ������ �� ������ ����� ���������� ������������, � ��� ����� � ������� �������. ����� ���������� ����������� �� �������� � ���� ��������: �������, ������, ���������, ����������� ���������� � ������� - ����������. ������� ��������� � ��������� �� �������, �������� ����� (��������-��������).", AuthorId = 1, CategoryId = 1, Price = 30});
            context.Books.AddOrUpdate(new Book { Id = 2, Name = "����� � ��������", Description = "� 1830 ���� ������ ��������� ������� ������. ������ � ������ ���� ��������� ��-�� ���������, � ��������� ��������� ������ �������� � ����������� �������������� � ������ ������� �������. ���������� ����� ����� � ������� ��� ����� ������������ ���������� ������ ��������. �� ��� ������ �� ������ ����� ���������� ������������, � ��� ����� � ������� �������. ����� ���������� ����������� �� �������� � ���� ��������: �������, ������, ���������, ����������� ���������� � ������� - ����������. ������� ��������� � ��������� �� �������, �������� ����� (��������-��������).", AuthorId = 1, CategoryId = 1 ,Price = 40});
            context.Books.AddOrUpdate(new Book { Id = 3, Name = "����� ����", Description = " �� �������, �������� ����� (��������-��������. Lorem ipsum dolor sit amet consectetur adipisicing elit. Reprehenderit, possimus a quidem corporis ad impedit, omnis sed eos adipisci fugit et incidunt! Dignissimos autem officia assumenda magnam animi nesciunt laborum sed voluptatum id hic error unde reiciendis nam ipsum beatae, fugiat ea cum nisi ullam laudantium. Delectus assumenda repellendus numquam amet obcaecati atque, beatae harum vero voluptatem, dicta, excepturi est!", AuthorId = 2, CategoryId = 1,Price = 23});
            context.Books.AddOrUpdate(new Book { Id = 4, Name = "������� ����", Description = "��� ����� � ������� �������. ����� ���������� ����������� �� �������� � ���� ��������: �������, ������, ���������, ����������� ���������� � ������� - ����������. ������� ��������� � ��������� �� �������, �������� ����� (��������-��������).", AuthorId = 3, CategoryId = 2,Price = 43});
            context.Books.AddOrUpdate(new Book { Id = 5, Name = "CLR via C#", Description = "� 1��� �������������� � ������ ������� �������. ���������� ����� ����� � ������� ��� ����� ������������ ���������� ������ ��������. �� ��� ������ �� ������ ����� ���������� ������������, � ��� ����� � ������� �������. ����� ���������� ����������� �� �������� � ���� ��������: �������, ������, ���������, ����������� ���������� � ������� - ����������. ������� ��������� � ��������� �� �������, �������� ����� (��������-��������).", AuthorId = 3, CategoryId = 3, Price = 53});
            context.Books.AddOrUpdate(new Book {  Name = "������� ������", Description = "� 1830 ���� ������ ��������� ������� ������. ������ � ������ ���� ��������� ��-�� ���������, � ��������� ��������� ������ �������� � ����������� �������������� � ������ ������� �������. ���������� ����� ����� � ������� ��� ����� ������������ ���������� ������ ��������. �� ��� ������ �� ������ ����� ���������� ������������, � ��� ����� � ������� �������. ����� ���������� ����������� �� �������� � ���� ��������: �������, ������, ���������, ����������� ���������� � ������� - ����������. ������� ��������� � ��������� �� �������, �������� ����� (��������-��������).", AuthorId = 1, CategoryId = 1, Price = 30 });
            context.Books.AddOrUpdate(new Book {  Name = "��������� ��������������", Description = "� 1830 ���� ������ ��������� ������� ������. ������ � ������ ���� ��������� ��-�� ���������, � ��������� ��������� ������ �������� � ����������� �������������� � ������ ������� �������. ���������� ����� ����� � ������� ��� ����� ������������ ���������� ������ ��������. �� ��� ������ �� ������ ����� ���������� ������������, � ��� ����� � ������� �������. ����� ���������� ����������� �� �������� � ���� ��������: �������, ������, ���������, ����������� ���������� � ������� - ����������. ������� ��������� � ��������� �� �������, �������� ����� (��������-��������).", AuthorId = 1, CategoryId = 1, Price = 40 });
            context.Books.AddOrUpdate(new Book {  Name = "��� �����", Description = " �� �������, �������� ����� (��������-��������).Lorem ipsum dolor sit amet consectetur adipisicing elit. Reprehenderit, possimus a quidem corporis ad impedit, omnis sed eos adipisci fugit et incidunt! Dignissimos autem officia assumenda magnam animi nesciunt laborum sed voluptatum id hic error unde reiciendis nam ipsum beatae, fugiat ea cum nisi ullam laudantium. Delectus assumenda repellendus numquam amet obcaecati atque, beatae harum vero voluptatem, dicta, excepturi est!", AuthorId = 2, CategoryId = 1, Price = 23 });
            context.Books.AddOrUpdate(new Book {  Name = "����� ���", Description = "��� ����� � ������� �������. ����� ���������� ����������� �� �������� � ���� ��������: �������, ������, ���������, ����������� ���������� � ������� - ����������. ������� ��������� � ��������� �� �������, �������� ����� (��������-��������).",AuthorId = 3,CategoryId = 2, Price = 43 });
            context.Books.AddOrUpdate(new Book {  Name = "���������", Description = "� 1��� �������������� � ������ ������� �������. ���������� ����� ����� � ������� ��� ����� ������������ ���������� ������ ��������. �� ��� ������ �� ������ ����� ���������� ������������, � ��� ����� � ������� �������. ����� ���������� ����������� �� �������� � ���� ��������: �������, ������, ���������, ����������� ���������� � ������� - ����������. ������� ��������� � ��������� �� �������, �������� ����� (��������-��������).", AuthorId = 3, CategoryId = 3, Price = 53 });

            //End Books Initialize

            //Start Authors Initialize
            context.Authors.AddOrUpdate(new Author { Id = 1, Name = "�.�.������" });
            context.Authors.AddOrUpdate(new Author { Id = 2, Name = "�.�.���������" });
            context.Authors.AddOrUpdate(new Author { Id = 3, Name = "������ ����" });
            //End Authors Initialize

            //Start Categories Initialize
            context.Categories.AddOrUpdate(new Category { Id = 1, CategoryName = "��������" });
            context.Categories.AddOrUpdate(new Category { Id = 2, CategoryName = "�������" });
            context.Categories.AddOrUpdate(new Category { Id = 3, CategoryName = "�����" });
            context.Categories.AddOrUpdate(new Category { Id = 4, CategoryName = "������" });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
