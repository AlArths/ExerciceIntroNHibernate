drop table if exists visit;
drop table if exists prospect;

create table prospect (
    prosp_id integer not null primary key auto_increment,
    prosp_last_name varchar(100) not null,
    prosp_first_name varchar(100) not null,
	prosp_mail varchar(100),
	prosp_last_contact datetime,
	prosp_notes varchar(1000)
);

create table visit (
	visit_id integer not null primary key auto_increment,
	visit_date datetime not null,
	visit_purpose varchar(200) not null,
	visit_outcome varchar(1000) not null,
	prosp_id integer null,
	constraint fk_visit_prosp foreign key(prosp_id) references prospect(prosp_id)
);