package com.payrollhr.rest_api.controller;

import com.payrollhr.rest_api.data_repository.StudentRepository;
import com.payrollhr.rest_api.model.Student;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.util.UriComponentsBuilder;

import javax.validation.Valid;
import java.util.UUID;
import java.util.Vector;

@RestController
@RequestMapping("/api/student")
public class StudentController {

    @Autowired
    StudentRepository repository;

    @GetMapping("{id}")
    public ResponseEntity<?> Get(@Valid @PathVariable UUID id) throws Exception {
        //throw new IllegalArgumentException("The parent path cannot be null!");

        var result = this.repository.findById(id);
        return new ResponseEntity<>(result, HttpStatus.OK);
    }


    @GetMapping
    public ResponseEntity<?> Gets()//
    {
        var result = this.repository.findAll();
        if (result.isEmpty()) {
            return new ResponseEntity<>(HttpStatus.NO_CONTENT);
        }
        return new ResponseEntity<>(result, HttpStatus.OK);
    }

    @PostMapping
    public ResponseEntity<?> Add(@Valid @RequestBody Student student, UriComponentsBuilder ucBuilder) //
    {
        if (this.repository.existsById(student.get_ID())) {
            return new ResponseEntity<>(HttpStatus.CONFLICT);
        }

        //------------
        student.set_id();
        //------------
        student = this.repository.save(student);
        return new ResponseEntity<>(student, HttpStatus.CREATED);
    }

    @PutMapping
    public ResponseEntity<?> Update(@Validated @RequestBody Student student, UriComponentsBuilder urBuilder) {

        if (!this.repository.existsById(student.get_ID())) {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
        student = this.repository.save(student);
        return new ResponseEntity<>(student, HttpStatus.OK);
    }

    @DeleteMapping("{id}")
    public ResponseEntity<String> Delete(@PathVariable UUID id, UriComponentsBuilder urBuilder) {

        if (!this.repository.existsById(id)) {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
        this.repository.deleteById(id);
        return new ResponseEntity<>(HttpStatus.NO_CONTENT);
    }

    @PostMapping("/y")
    public ResponseEntity<?> seedData1() {
        Vector<Student> students = new Vector<>();
        Student student = new Student();
        student.set_id();
        student.name = "Kuch Saral";
        student.test = "-test-";
        students.add(student);
        this.repository.saveAll(students);

        //NullAndEnumUtils.getInstance().copyProperties(power, powerForm);
        //BeanUtilsBean b;

        return new ResponseEntity<>(students, HttpStatus.CREATED);
    }

    @PostMapping("/x")
    public ResponseEntity<?> seedData() {

        Vector<Student> students = new Vector<>();
        Student student = new Student();
        student.set_id();
        student.name = "Kuch Saral";
        students.add(student);

        student = new Student();
        student.set_id();
        student.name = "Kuch Saral1";
        students.add(student);

        student = new Student();
        student.set_id();
        student.name = "Kuch Saral2";
        students.add(student);

        student = new Student();
        student.set_id();
        student.name = "Kuch Saral3";
        students.add(student);

        student = new Student();
        student.set_id();
        student.name = "Kuch Saral4";
        students.add(student);

        student = new Student();
        student.set_id();
        student.name = "Kuch Saral5";
        students.add(student);

        student = new Student();
        student.set_id();
        student.name = "Kuch Saral6";
        students.add(student);

        this.repository.saveAll(students);
        return new ResponseEntity<>(HttpStatus.CREATED);
    }

}