package com.payrollhr.rest_api.controller;

import com.payrollhr.rest_api.data_repository.CompanyRepository;
import com.payrollhr.rest_api.exceptionhandling.ResourceNotFoundException;
import com.payrollhr.rest_api.model.Company;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.util.UriComponentsBuilder;

import javax.validation.Valid;
import java.util.Optional;
import java.util.UUID;
import java.util.Vector;

@RestController
@RequestMapping("/api/company")
public class CompanyController {

    @Autowired
    CompanyRepository repository;

    @GetMapping("{id}")
    public ResponseEntity<?> Get(@Valid @PathVariable UUID id) throws ResourceNotFoundException {
        //throw new IllegalArgumentException("The parent path cannot be null!");

        Optional<Company> optionalCompany = Optional.empty();
        var result = this.repository.findById(id);
        if (result == optionalCompany) throw new ResourceNotFoundException("Company not found");

        return new ResponseEntity<>(result, HttpStatus.OK);
    }

    @GetMapping
    public ResponseEntity<?> Gets() throws Exception//
    {
        var result = this.repository.findAll();
        return new ResponseEntity<>(result, HttpStatus.OK);
    }

    @PostMapping
    public ResponseEntity<?> Add(@Valid @RequestBody Company company, UriComponentsBuilder ucBuilder) throws Exception//
    {
        if (this.repository.existsById(company.get_ID())) throw new Exception("Company is exist");
        company = this.repository.save(company);
        return new ResponseEntity<>(company, HttpStatus.CREATED);
    }

    @PutMapping
    public ResponseEntity<?> Update(@Validated @RequestBody Company company, UriComponentsBuilder urBuilder) throws ResourceNotFoundException{

        if (!this.repository.existsById(company.get_ID()))throw new ResourceNotFoundException("Company not found");
        company = this.repository.save(company);
        return new ResponseEntity<>(company, HttpStatus.OK);
    }

    @DeleteMapping("{id}")
    public ResponseEntity<String> Delete(@Valid @PathVariable UUID id, UriComponentsBuilder urBuilder) throws  ResourceNotFoundException{

        if (!this.repository.existsById(id)) throw new ResourceNotFoundException("Company not found");
        this.repository.deleteById(id);
        return new ResponseEntity<>(HttpStatus.NO_CONTENT);
    }

    @PostMapping("/x")
    public ResponseEntity<?> seedData() {

        Vector<Company> companies = new Vector<>();
        Company company = new Company();
        company.set_id();
        //company.companyName = "OKoone";
        companies.add(company);

        this.repository.saveAll(companies);
        return new ResponseEntity<>(HttpStatus.CREATED);
    }
}