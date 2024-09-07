ALTER TABLE participants
ADD CONSTRAINT pk_participants PRIMARY KEY (id_participant);

ALTER TABLE clients
ADD CONSTRAINT pk_clients PRIMARY KEY (id_clt);

ALTER TABLE evenement
ADD CONSTRAINT pk_evenement PRIMARY KEY (id_even);