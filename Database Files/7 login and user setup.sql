--replace //loginname// and //password// with secret values from vault

--use master

create login //loginname// with  '//password//'

--use HeartyHearth
create user dev1_user from login dev1_login

alter role db_datareader add member dev1_user
alter role db_datawriter add member dev1_user