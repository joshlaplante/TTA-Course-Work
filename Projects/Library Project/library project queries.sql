--1. How many copies of the book titled The Lost Tribe are owned by the library branch whose name
--is"Sharpstown"?

create proc getSharpstownLostTribeCopies
as
	select library_branch.branchName, book_copies.no_of_copies 
	from book
	inner join book_copies
	on book.bookID = book_copies.bookID
	inner join library_branch
	on book_copies.branchID = library_branch.branchID
	where book.title = 'The Lost Tribe'
	and library_branch.branchName = 'Sharpstown'

go

--2. How many copies of the book titled The Lost Tribe are owned by each library branch?

create proc getAllLostTribeCopies
as 
	select library_branch.branchName, book_copies.no_of_copies 
	from book
	inner join book_copies
	on book.bookID = book_copies.bookID
	inner join library_branch
	on book_copies.branchID = library_branch.branchID
	where book.title = 'The Lost Tribe'
	
go

--3. Retrieve the names of all borrowers who do not have any books checked out.
create proc noBooksCheckedOut
as
	select borrower.name from borrower
	left outer join book_loans
	on borrower.cardNo = book_loans.cardNo
	where book_loans.cardNo is Null
	
go

--4. For each book that is loaned out from the "Sharpstown" branch and whose DueDate is today,
--retrieve the book title, the borrower's name, and the borrower's address.
create proc sharpstownDueToday
as
	select book.title, borrower.name, borrower.[address]
	from library_branch
	inner join book_loans
	on library_branch.branchID = book_loans.branchID
	inner join borrower
	on book_loans.cardNo = borrower.cardNo
	inner join book
	on book_loans.bookID = book.bookID
	where library_branch.branchName = 'Sharpstown'
	and convert(date, GETDATE()) = book_loans.dueDate

go

--5. For each library branch, retrieve the branch name and the total number of books loaned out from
--that branch.

create proc noOfBooksLoanedOutByBranch
as
	select library_branch.branchID, COUNT(*) as noOfBooksLoanedOut
	from library_branch
	inner join book_loans
	on library_branch.branchID = book_loans.branchID
	group by library_branch.branchID

--  this method returns the different branches in separate tables, too clunky
--
--	select COUNT(library_branch.branchID) as SharpstownLoanedOut
--	from library_branch
--	inner join book_loans
--	on library_branch.branchID = book_loans.branchID
--	where library_branch.branchID = 1
--
--	select COUNT(library_branch.branchID) as CentralLoanedOut
--	from library_branch
--	inner join book_loans
--	on library_branch.branchID = book_loans.branchID
--	where library_branch.branchID = 2
--
--	select COUNT(library_branch.branchID) as WinterfellLoanedOut
--	from library_branch
--	inner join book_loans
--	on library_branch.branchID = book_loans.branchID
--	where library_branch.branchID = 3
--
--	select COUNT(library_branch.branchID) as SolitudeLoanedOut
--	from library_branch
--	inner join book_loans
--	on library_branch.branchID = book_loans.branchID
--	where library_branch.branchID = 4

go

--6. Retrieve the names, addresses, and number of books checked out for all borrowers who have more
--than five books checked out.

create proc moreThanFiveBooksCheckedOut
as
	select book_loans.cardNo, COUNT(book_loans.cardNo) as noOfBooksCheckedOut, borrower.name, borrower.[address]
	from book_loans
	inner join borrower
	on book_loans.cardNo = borrower.cardNo
	group by book_loans.cardNo, borrower.name, borrower.[address]
	having COUNT(book_loans.cardNo)>5
	
go

--7. For each book authored (or co-authored) by "Stephen King", retrieve the title and the number of
--copies owned by the library branch whose name is "Central"

create proc stephenKingCentralCopies
as
	select book.title, book_copies.no_of_copies
	from book_copies
	inner join book
	on book.bookID = book_copies.bookID
	inner join library_branch
	on book_copies.branchID = library_branch.branchID
	inner join book_authors
	on book_copies.bookID = book_authors.bookID
	where library_branch.branchName = 'Central'
	and book_authors.authorName like 'Stephen King'

go

-- the following procedure will run all procedures defined above

create proc runAllProcedures
as
	exec getSharpstownLostTribeCopies
	exec getAllLostTribeCopies
	exec noBooksCheckedOut
	exec sharpstownDueToday
	exec noOfBooksLoanedOutByBranch
	exec moreThanFiveBooksCheckedOut
	exec stephenKingCentralCopies

exec runAllProcedures